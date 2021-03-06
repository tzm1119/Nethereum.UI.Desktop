using Nethereum.StandardToken.UI.ViewModels;
using Nethereum.UI.ViewModels;

namespace Nethereum.UI.Desktop.Views.StandardToken.Designers
{
    public class StandardTokenTransferViewModelDesigner : StandardTokenTransferViewModel
    {
        public StandardTokenTransferViewModelDesigner()
        {
            this.AddressTo = "0x13f022d72158410433cbd66f5dd8bf6d2d129924";
            this.Amount = 100;
            this.Gas = (ulong)Nethereum.Signer.Transaction.DEFAULT_GAS_LIMIT;
            this.GasPrice = (ulong)Nethereum.Signer.Transaction.DEFAULT_GAS_PRICE;
        }
    }
}