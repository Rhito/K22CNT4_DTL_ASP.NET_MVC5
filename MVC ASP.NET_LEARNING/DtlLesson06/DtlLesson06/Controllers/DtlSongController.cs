using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.HtmlControls;
using DtlLesson06.Models;

namespace DtlLesson06.Controllers
{
    public class DtlSongController : Controller
    {
        private static List<DtlSong> dtlSongs = new List<DtlSong>()
        {
            new DtlSong()
            {
                Id=2210900038,
                DtlTitle="Đinh Tiến Lực",
                DtlAuthor="K22CNT4",
                DtlArtist="NTU",
                DtlYearRelease=2020
            },
            new DtlSong()
            {
                Id=1,
                DtlTitle="Đinh Tiến Lực",
                DtlAuthor="K22CNT4",
                DtlArtist="NTU",
                DtlYearRelease=2020
            },
        };
        // GET: DtlSong
        /// <summary>
        /// Hiển thị danh sách bài hát
        /// Author: Đinh Tiến Lực
        /// </summary>
        /// <returns></returns>
        public ActionResult DtlIndex()
        {
            return View(dtlSongs);
        }

        // GET: DtlCreate
        /// <summary>
        /// Form Thêm mới bài hát
        /// Author: Đinh Tiến Lưch
        /// </summary>
        /// <returns></returns>
        public ActionResult DtlCreate() 
        {
            var dtlSong = new DtlSong()
            {
                DtlYearRelease = 2024
            };
            return View(dtlSong);
        }
    }
}