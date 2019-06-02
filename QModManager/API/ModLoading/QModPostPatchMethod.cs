﻿namespace QModManager.API.ModLoading
{
    using QModManager.API.ModLoading.Internal;
    using System;

    /// <summary>
    /// Identifies a post-patch method for a QMod.<para/>
    /// ALERT: The class that defines this method must have a <seealso cref="QModCoreInfo"/> attribute.
    /// </summary>
    /// <seealso cref="Attribute" />
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class QModPostPatchMethod : Attribute, IPatchMethod
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QModPostPatchMethod"/> class for post-patching.
        /// </summary>
        public QModPostPatchMethod()
        {
        }

        /// <summary>
        /// Gets the patch method's meta patch order.
        /// </summary>
        public PatchingOrder PatchOrder { get; } = PatchingOrder.PostInitialize;
    }
}