﻿using BZY.OA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BZY.OA.IBLL
{
    public partial interface IRoleInfoService : IBaseService<RoleInfo>
    {
        bool SetRoleActionInfo(int roleId, List<int> actionIdList);
    }
}
