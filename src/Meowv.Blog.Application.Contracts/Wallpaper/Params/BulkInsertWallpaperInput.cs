using Meowv.Blog.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Meowv.Blog.Wallpaper.Params
{
    public class BulkInsertWallpaperInput
    {
        /// <summary>
        /// 类型
        /// </summary>
        public WallpaperEnum Type { get; set; }

        /// <summary>
        /// 壁纸列表
        /// </summary>
        public IEnumerable<WallpaperDto> Wallpapers { get; set; }
    }
}
