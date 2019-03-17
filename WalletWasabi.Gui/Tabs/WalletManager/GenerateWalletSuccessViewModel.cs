﻿using NBitcoin;
using ReactiveUI;
using System;
using System.Reactive.Disposables;
using WalletWasabi.Gui.ViewModels;

namespace WalletWasabi.Gui.Tabs.WalletManager
{
	internal class GenerateWalletSuccessViewModel : CategoryViewModel
	{ 
		private string _mnemonicWords;

		public GenerateWalletSuccessViewModel(WalletManagerViewModel owner, Mnemonic mnemonic) : base("Wallet Generated Successfully!")
		{
			_mnemonicWords = mnemonic.ToString();

			ConfirmCommand = ReactiveCommand.Create(() =>
			{
				owner.SelectTestPassword();
			});
		}

		public string MnemonicWords
		{
			get => _mnemonicWords;
			set => this.RaiseAndSetIfChanged(ref _mnemonicWords, value);
		}

		public ReactiveCommand ConfirmCommand { get; }

		public override void OnCategorySelected()
		{
			base.OnCategorySelected();
		}
	}
}
