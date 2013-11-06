using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace practica6
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			String codigo = cod.Text;
			String nombre = nom.Text;
			
			int aciertos=0;
			if(this.id1.Checked==true){
				aciertos++;
			}
			if (this.portugal.Checked==true){
				aciertos++;
			}
			if(this.ru.Checked==true){
				aciertos++;
			}
			if (this.mac.Checked==true){
				aciertos++;
			}
			if(this.numericUpDown1.Text == "32"){
                aciertos++;
			}

			DateTime fecha = Calendar1.SelectionStart;

			if(fecha.ToShortDateString()=="07/05/1945"){
				aciertos++;
			}

			MessageBox.Show("codigo: "+cod.Text+"\nnombre: "+nom.Text+"\naciertos: "+aciertos);	
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
