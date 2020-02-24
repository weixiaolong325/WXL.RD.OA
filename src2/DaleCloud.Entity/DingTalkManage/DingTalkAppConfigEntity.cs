﻿/*******************************************************************************
 * Copyright © 2018 DaleCloud.Framework 版权所有
 * Author: DaleCloud
 * Description: DaleCloud
 * Website：
*********************************************************************************/

using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;

namespace DaleCloud.Entity.DingTalk
{
    //DingTalkCorpConfig
    public class DingTalkAppConfigEntity : IEntityV2<DingTalkAppConfigEntity>, ICreationAuditedV2, IModificationAuditedV2
    {
        /// <summary>
        /// 主键
        /// </summary>		
        public string uuId { get; set; }
        /// <summary>
        /// AppCode
        /// </summary>	
        public int AppCode { get; set; }
        /// <summary>
        /// AppName
        /// </summary>	
        public string AppName { get; set; }
        /// <summary>
        /// AgentId
        /// </summary>	
        public string AgentId { get; set; }
        /// <summary>
        /// AppId
        /// </summary>		
        public string AppId { get; set; }
        /// <summary>
        /// AppKey
        /// </summary>	
        public string AppKey { get; set; }
        /// <summary>
        /// AppSecret
        /// </summary>	
        public string AppSecret { get; set; }
        /// <summary>
        /// Access_Token
        /// </summary>
        public string Access_Token { get; set; }
        /// <summary>
        ///创建人
        /// </summary>		
        public string Creator { get; set; }
        /// <summary>
		/// 创建人ID
        /// </summary>		
        public string CreatorId { get; set; }
        /// <summary>
		/// 创建时间
        /// </summary>		
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>		
        public string Modifier { get; set; }
        /// <summary>
        /// 修改人ID
        /// </summary>		
        public string ModifierId { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>		
        public DateTime? ModifyTime { get; set; }
        /// <summary>
        /// 删除人ID
        /// </summary>		
        public string DeleterId { get; set; }
        /// <summary>
        /// 删除时间
        /// </summary>		
        public DateTime? DeleteTime { get; set; }
    }
}


