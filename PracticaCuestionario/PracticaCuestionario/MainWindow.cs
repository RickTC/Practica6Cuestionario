using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	
	int puntos=0;
	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	
	public void preguntas()
	{
		
		if (this.radiodf.Active)
		{
			puntos++;
		}
		
		if(this.checkportugal.Active)
		{
			puntos++;
		}
		if(this.checkreino.Active)
		{
			puntos++;
		}
		if(this.checkmace.Active)
		{
			puntos++;
		}
		
		if(this.estados.Text == "31")
		{
			puntos++;
		}
		
		if(calendario.GetDate().ToShortDateString() == "07/05/1945")
		{
			puntos++;
		}
		
	}
	
	
	protected void OnTerminarClicked (object sender, System.EventArgs e)
	{
		preguntas();
		MessageDialog mensaje = new MessageDialog 
		(
			null,
			DialogFlags.Modal,
			MessageType.Info,
			ButtonsType.None,"Codigo: "+ codigo.Text +"\n"+
							  "Nombre: "+ nombre.Text +"\n"+
								"Puntos obtenidos: "+puntos
		);
		mensaje.Show();
	}
}
