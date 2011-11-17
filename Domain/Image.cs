namespace ShoeboxedService.Domain
{
    public class Image
    {
        public string ImgURL { get; private set; }
        public int Index { get; private set; }

        public Image(string imgURL, int index)
        {
            ImgURL = imgURL;
            Index = index;
        }
    }
}
