﻿using Abp.Modules;
using FranchiseePortal.Test.Base;

namespace FranchiseePortal.Tests
{
    [DependsOn(typeof(FranchiseePortalTestBaseModule))]
    public class FranchiseePortalTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            base.PreInitialize();
        }
    }
}
