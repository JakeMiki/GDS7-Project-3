﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDS7.Group1.Project3.Assets.Scripts.State
{
    public interface IGroundedState
    {
        bool IsGrounded { get; }
        float DistanceFromGround { get; }
    }
}
