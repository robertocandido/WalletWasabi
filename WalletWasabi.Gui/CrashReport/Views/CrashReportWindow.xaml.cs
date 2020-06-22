using System;
using System.ComponentModel;
using Avalonia;
using Avalonia.Markup.Xaml;
using AvalonStudio.Shell.Controls;
using Splat;

namespace WalletWasabi.Gui.CrashReport.Views
{
	public class CrashReportWindow : MetroWindow
	{
		public CrashReportWindow()
		{
			InitializeComponent();
#if DEBUG
			this.AttachDevTools();
#endif
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}
	}
}
