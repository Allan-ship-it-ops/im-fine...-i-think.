using System;
using System.Drawing;
using System.Windows.Forms;

public class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        
        var result = MessageBox.Show("Are you sure you want to open this?", "Security Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        if (result == DialogResult.Yes) 
        {
            for (int i = 0; i < 10; i++) 
            {
                Form erroForm = new Form();
                erroForm.Text = "///ERROR: This user cannot be reached anymore.";
                erroForm.Size = new Size(400, 300);
                erroForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                erroForm.StartPosition = FormStartPosition.Manual;
                erroForm.Location = new Point(100 + (i * 40), 100 + (i * 40));
                PictureBox pb = new PictureBox();
                pb.Image = Image.FromFile(@"C:\Users\henrmac1181\Desktop\crashout\sad.gif"); 
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Dock = DockStyle.Fill;

                erroForm.Controls.Add(pb);
                
                
                erroForm.Show(); 
            }
            
            
            Application.Run();
        }
    }
}
