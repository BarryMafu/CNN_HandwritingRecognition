namespace CNN_HandwritingRecognition
{
    public partial class Form1 : Form
    {
        private bool isDrawing; // to indicate whether the mouse is down or not
        private Point lastPoint; // to indicate the last point
        private Point curPoint;
        private Bitmap bitmap;

        public enum Mode
        {
            EnlargingTheDatabase,
            Training,
            Testing
        }

        private Mode current_mode;

        /* get the current mode */
        public Mode CurrentMode
        {
            get => current_mode;
            set
            {
                current_mode = value;
                SwitchTo(value);
            }

        }

        public Form1()
        {
            InitializeComponent();

            /* Use Double Buffer to decrease blinking */
            this.DoubleBuffered = true;

            /* Initialize the bitmap */
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            // bitmap.PixelFormat = System.Drawing.Imaging.PixelFormat.Format8bppIndexed;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            /* meet the require of base */
            base.OnPaint(e);
            if (isDrawing)
            {
                using (var graphics = Graphics.FromImage(bitmap))
                {
                    graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;

                    // pen draw
                    Pen blackpen = new Pen(Color.Black, 12);
                    graphics.DrawLine(blackpen, lastPoint, curPoint);
                    // Ellipse draw
                    Rectangle r1 = new Rectangle(lastPoint.X - 6, lastPoint.Y - 6, 12, 12);
                    Rectangle r2 = new Rectangle(curPoint.X - 6, curPoint.Y - 6, 12, 12);
                    graphics.FillEllipse(Brushes.Black, r1);
                    graphics.FillEllipse(Brushes.Black, r2);
                }
                pictureBox1.Image = bitmap; // Update the picturebox
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            curPoint = e.Location;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            lastPoint = curPoint;
            curPoint = e.Location;
            OnPaint(new PaintEventArgs(this.CreateGraphics(), this.ClientRectangle));
        }

        private void SwitchTo(Mode mode)
        {
            switch (mode)
            {
                case Mode.EnlargingTheDatabase:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            current_mode = Mode.EnlargingTheDatabase;
        }
    }
}