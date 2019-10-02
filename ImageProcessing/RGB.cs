namespace ImageProcessing
{
    public class RGB
    {
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }

        public void Append(int r, int g, int b)
        {
            R += r;
            G += g;
            B += b;
        }
    }
}
