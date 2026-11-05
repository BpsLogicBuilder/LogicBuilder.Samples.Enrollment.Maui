using Enrollment.Data.Entities;
using Enrollment.Domain.Entities;
using LogicBuilder.App.Utils.Interfaces;
using System;

namespace Enrollment.XPlatform.Flow
{
    internal static class Constants
    {//These type references facilitate typeloading for the Logic Builder at design time.
        public static readonly Type[] TypeReferences = [typeof(UserModel), typeof(User), typeof(ITypeHelper)];
    }
}
