using Core.Framework.Enums;
using Core.IoC;
using System;

namespace Core.Framework.Attributes
{
    /// <summary>
    /// This attribute give you the ability to declare IoC injection behavor as meta-data on a class intended to be used in a dependeny injection context
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
    public sealed class InjectableAttribute : Attribute
    {
        /// <summary>
        /// Specifies the interface to be automattically mapped to the class with the Injectable attribute for IoC. When this value is null and a class has this attribute, it will assume the first interface on this class should be used for the mapping
        /// </summary>
        /// <exception cref="InvalidOperationException"> Thrown when this attribute exists on a class, but InterfaceToMap is null and no interfaces exist on the class</exception>
        public Type MapTo { get; set; }

        /// <summary>
        /// Allows the class to opt-out of the auto-wiring IoC process. This would also support any IoC auto-wiring where classes are expected to exlicitly opt-in
        /// </summary>
        public Opt AutoWiring { get; set; }

        /// <summary>
        /// The lifetime to be used when registering types for the container
        /// </summary>
        public RegistrationLifetime Lifetime { get; set; }
    }
}
