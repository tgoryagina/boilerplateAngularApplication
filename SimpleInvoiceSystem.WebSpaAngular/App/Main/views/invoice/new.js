(function () {
    var controllerId = 'app.views.newinvoice';
    angular.module('app').controller(controllerId, [
        '$scope','$modal', 'abp.services.invoicesystem.invoice', 
        function ($scope, modal, invoiceService) {
            var vm = this;
            
            vm.localize = abp.localization.getSource('SimpleInvoiceSystem');

            vm.invoices = [];
            vm.totalPrice = '';

            vm.refreshTasks = function() {
                abp.ui.setBusy(
                    null,
                    invoiceService.getInvoices({ id: null }).success(function(data) {
                        vm.invoices = data.invoices;
                    })
                );
            };

            vm.deleteInvoice = function (invoice) {
                var index = vm.invoices.indexOf(invoice);
                vm.invoices.splice(index, 1);
            };
            
            vm.getInvoiceTotalPrice = function () {
                
                var total = 0;
                for (var i = 0; i < vm.invoices.length; i++) {
                    var inv = vm.invoices[i];
                    total += inv.Price;
                }

                return abp.utils.formatString(vm.localize('TotalPrice'), total);
            };
            
            vm.addOrEditInvoice = function (item) {
                var mbox = modal.open({
                    templateUrl: '/App/Main/views/invoice/invoiceCreation.cshtml',
                    controller: 'app.views.editinvoice',
                    resolve: {
                        item: function () {
                            return {
                                invoice: item == null ? {} : angular.copy(item)
                            };
                        }
                    }
                });
                mbox.result.then(function (result) {
                    if (result) {
                        vm.refreshTasks();
                        if (!item)
                            $scope.notify(vm.localize('InvoiceCreateMessage'));
                    }
                });
            };

            vm.refresh = function () {
                vm.refreshTasks();
                vm.totalPrice = vm.getInvoiceTotalPrice();
            };
        }
    ]);
 })
();

