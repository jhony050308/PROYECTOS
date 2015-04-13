using System;
using Xamarin.Forms;

namespace Actividad9
{
	public class Contenido: ContentPage
	{
		public Contenido ()
		{
			Label texto = new Label {
				Text = "Actividad 9",
				TextColor = Color.Green
			};

			StackLayout stackLayout = new StackLayout 
			{
				Children = 
				{
					texto

				}
				};

			this.Content = stackLayout;
			this.Padding = new Thickness (5, Device.OnPlatform (20, 5, 5), 5, 5);
		}
	}
}



