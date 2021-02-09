using NBitcoin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletWasabi.WabiSabi.Backend.Banning;
using WalletWasabi.WabiSabi.Models;

namespace WalletWasabi.WabiSabi.Backend.PostRequests
{
	public class PostRequestHandler
	{
		public PostRequestHandler(WabiSabiConfig config, Prison prison)
		{
			Config = config;
			Prison = prison;
		}

		public WabiSabiConfig Config { get; }
		public Prison Prison { get; }

		public InputsRegistrationResponse RegisterInput(InputsRegistrationRequest request)
		{
			throw new NotImplementedException();
		}

		public void RemoveInput(InputsRemovalRequest request)
		{
			throw new NotImplementedException();
		}

		public ConnectionConfirmationResponse ConfirmConnection(ConnectionConfirmationRequest request)
		{
			throw new NotImplementedException();
		}

		public OutputRegistrationResponse RegisterOutput(OutputRegistrationRequest request)
		{
			throw new NotImplementedException();
		}

		public void SignTransaction(TransactionSignaturesRequest request)
		{
			throw new NotImplementedException();
		}
	}
}
