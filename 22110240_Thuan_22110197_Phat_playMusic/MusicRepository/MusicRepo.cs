using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicRepository
{
    public class MusicRepo
    {
        LinkedList2 music = new LinkedList2();
        LinkedList2 favoriteList = new LinkedList2();
        public void Innit()
        {
         //   music.AddNode(new Audio("bật tình yêu lên", "C:\\C#\\Window Form\\ThuanPhat.Project\\BatTinhYeuLen-TangDuyTanHoaMinzy-8715666.mp3", false));
            //music.AddNode(new Audio("Cold dont", "C:\\C#\\Window Form\\ThuanPhat.Project\\ColdDont-NmocDmeanVietNamAstacVietNam-8972177.mp3", false));
        }
        public LinkedList2 getAll()
        {
            return music;
        }
        public LinkedList2 getMusicList(LinkedList2 q) {
            music = q;
            return music;
        }

        public LinkedList2 getFavoriteList()
        {
            return favoriteList;
        }


    }
}
