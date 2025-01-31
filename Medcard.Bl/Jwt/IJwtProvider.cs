﻿using Medcard.Bl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medcard.Bl.Jwt
{
    public interface IJwtProvider
    {
        public string GenerateToken(string id);
    }
}
