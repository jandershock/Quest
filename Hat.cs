namespace Quest
{
    public class Hat
    {
        public int Shininess { get; set; }
        public string ShininessDescription
        {
            get
            {
                if (Shininess < 2)
                {
                    return "dull";
                }
                else if (Shininess >= 2 && Shininess <= 5)
                {
                    return "noticeable";
                }
                else if (Shininess >= 6 && Shininess <= 9)
                {
                    return "bright";
                }
                else if (Shininess > 9)
                {
                    return "blinding";
                }
                else
                {
                    return "Error";
                }
            }

        }
    }
}