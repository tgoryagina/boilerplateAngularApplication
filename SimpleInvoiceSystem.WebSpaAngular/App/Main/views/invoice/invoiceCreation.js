(function() {
    var controllerId = 'app.views.editinvoice';
    angular.module('app').controller(controllerId, [
        '$scope', '$modal', 'abp.services.invoicesystem.invoice', 'abp.services.invoicesystem.product',
        function ($scope, modal, invoiceService, productService) {
            var vm = this;
            
            vm.localize = abp.localization.getSource('SimpleInvoiceSystem');

            vm.invoice = {};
            vm.products = [];

            productService.getAllProduct().success(function (data) {
                vm.products = data.product;
            });
            
            vm.getInvoiceTotalPrice = function () {
                return abp.utils.formatString(vm.localize('TotalPrice'), vm.products.length);
            };
            
            vm.cancel = function () {
                modal.close();
            };
            
            vm.save= function () {
                abp.ui.setBusy(
                    null,
                    invoiceService.createInvoice(
                        vm.invoice
                    ).success(function () {
                        abp.notify.info(localize("InvoiceCreateMessage"));
                        modal.close();
                    })
                );
            };
        }
    ]);
})
();

