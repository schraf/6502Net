﻿using GalaSoft.MvvmLight.Messaging;

namespace Simulator
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow
	{
		public MainWindow()
		{
			InitializeComponent();
			Messenger.Default.Register<NotificationMessage>(this, NotificationMessageReceived);
		}

		private void NotificationMessageReceived(NotificationMessage notificationMessage)
		{
			if (notificationMessage.Notification == "OpenFileWindow")
			{
				var openFile = new OpenFile();
				openFile.ShowDialog();
			}
		}
	}
}