namespace WinFormsApp1plague
{
    public partial class Form1 : Form
    {
        Random random = new Random();
      
        private void MoveMouse()
        {
            int x = Screen.PrimaryScreen.Bounds.Width;
            int y = Screen.PrimaryScreen.Bounds.Height;
            int positionX = random.Next(x);
            int positionY = random.Next(y);
            Cursor.Position = new Point(positionX, positionY);
        }
        public Form1()
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoveMouse();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
