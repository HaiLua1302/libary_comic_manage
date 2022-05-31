using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libary_story_manage.model
{
    class cls_comics
    {
        private int comics_id;
        private string comics_name;
        private string comics_introduce;
        private string comics_style;
        private string comics_img;
        private string comics_cover_img;
        private string like_comics;
        private string comics_state;

        public cls_comics(int comics_id, string comics_name, string comics_introduce, string comics_style, string comics_img, string comics_cover_img, string like_comics, string comics_state)
        {
            this.comics_id = comics_id;
            this.comics_name = comics_name;
            this.comics_introduce = comics_introduce;
            this.comics_style = comics_style;
            this.comics_img = comics_img;
            this.comics_cover_img = comics_cover_img;
            this.like_comics = like_comics;
            this.comics_state = comics_state;
        }

        public int Comics_id { get => comics_id; set => comics_id = value; }
        public string Comics_name { get => comics_name; set => comics_name = value; }
        public string Comics_introduce { get => comics_introduce; set => comics_introduce = value; }
        public string Comics_style { get => comics_style; set => comics_style = value; }
        public string Comics_img { get => comics_img; set => comics_img = value; }
        public string Comics_cover_img { get => comics_cover_img; set => comics_cover_img = value; }
        public string Like_comics { get => like_comics; set => like_comics = value; }
        public string Comics_state { get => comics_state; set => comics_state = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }

}
