﻿#region License
// 
// Copyright (c) 2013, Kooboo team
// 
// Licensed under the BSD License
// See the file LICENSE.txt for details.
// 
#endregion
using Kooboo.CMS.Web2.Areas.Contents.Models.DataSources;
using Kooboo.CMS.Web2.Models;
using Kooboo.Common.Misc;
using Kooboo.Common.Web.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Kooboo.CMS.Web2.Areas.Contents.Models
{
    public class ImportRepositoryModel
    {
        [Required(ErrorMessage = "Required")]
        [Remote("IsNameAvailable", "Repository")]
        [RegularExpression(RegexPatterns.Alphanum, ErrorMessage = "Only alphameric and numeric are allowed in the field name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Required")]
        //[RegularExpression(".+\\.(zip)$", ErrorMessage = "Required a zip file.")]
        [UIHint("UploadOrSelect")]
        [DataSource(typeof(RepositoryTemplatesDataSource))]
        [Description("Import from uploaded template files or existing content database templates(under Cms_Data\\ImportedContents).")]
        [AdditionalMetadata("data-val-filesize", "The content file exceeds the maximum size can be uploaded. Please upload the file under Cms_Data\\ImportedContents folder via FTP, then switch to the selection mode.")]
        [AdditionalMetadata("data-val-filesize-value", 4194304)]
        public string File { get; set; }
    }
}