using System;
using System.Collections.Generic;

using StudySesh.Models;

using Xamarin.Forms;

namespace StudySesh
{
	public partial class addSeshPage : ContentPage
	{
		private Sesh newSesh = new Sesh();

		public addSeshPage()
		{
			InitializeComponent();
		}

		void Handle_SubjectChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
		{
			newSesh.subject = e.NewTextValue;
		}

		void Handle_TopicChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
		{
			newSesh.topic = e.NewTextValue;
		}

		void Handle_Submit(object sender, System.EventArgs e)
		{
			throw new NotImplementedException();
		}
	}
}
