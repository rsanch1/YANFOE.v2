﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MissingEpisodeTreeList.cs" company="The YANFOE Project">
//   Copyright 2011 The YANFOE Project
// </copyright>
// <license>
//   This software is licensed under a Creative Commons License
//   Attribution-NonCommercial-ShareAlike 3.0 Unported (CC BY-NC-SA 3.0) 
//   http://creativecommons.org/licenses/by-nc-sa/3.0/
//   See this page: http://www.yanfoe.com/license
//   For any reuse or distribution, you must make clear to others the 
//   license terms of this work.  
// </license>
// --------------------------------------------------------------------------------------------------------------------

namespace YANFOE.UI.Popups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class MissingEpisodeTreeList
    {
        public int id { set; get; }
        public int parent { set; get; }
        public string seriesname { set; get; }
        public int missingEpisodesCount { set; get; }
        public string episodename { set; get; }
    }
}
