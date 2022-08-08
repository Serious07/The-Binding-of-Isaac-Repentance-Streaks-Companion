using System.Drawing;

namespace SelectRandomCharacter
{
    public class Character
    {
        public Bitmap image;
        public string name;

        public Character(Bitmap image, string name) {
            this.image = image;
            this.name = name;
        }
    }
}
