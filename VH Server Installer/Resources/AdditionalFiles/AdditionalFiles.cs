using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VH_Server_Installer.Resources.AdditionalFiles
{
    internal class AdditionalFiles
    {
        public int id { get; set; }
        public DateTime dateCreated { get; set; }
        public DateTime dateModified { get; set; }
        public string displayName { get; set; }
        public int fileLength { get; set; }
        public string fileName { get; set; }
        public int status { get; set; }
        public int parentProjectFileId { get; set; }
        public int projectFileTypeId { get; set; }
        public List<object> gameVersions { get; set; }
        public List<object> gameVersionTypeIds { get; set; }
        public int releaseType { get; set; }
        public int totalDownloads { get; set; }
        public Releases.User user { get; set; }
        public int additionalFilesCount { get; set; }
        public bool hasServerPack { get; set; }
        public int additionalServerPackFilesCount { get; set; }
        public bool isEarlyAccessContent { get; set; }
        public bool isCompatibleWithClient { get; set; }
    }
}
