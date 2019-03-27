using System;
using System.Data;

namespace Core.Utilities
{
    /// <summary>
    /// A generic helper
    /// </summary>
    public interface IGlobalHelper
    {
        /// <summary>
        /// Gets a boolean or returns null from an object
        /// </summary>
        /// <param name="val">The object to get the value from</param>
        /// <returns>The result of the get</returns>
        bool? GetBooleanOrNull(object val);

        /// <summary>
        /// Gets a DateTime or returns null from an object
        /// </summary>
        /// <param name="val">The object to get the value from</param>
        /// <returns>The result of the get</returns>
        DateTime? GetDateTimeOrNull(object val);

        /// <summary>
        /// Gets a decimal or returns null from an object
        /// </summary>
        /// <param name="val">The object to get the value from</param>
        /// <returns>The result of the get</returns>
        decimal? GetDecimalOrNull(object val);

        /// <summary>
        /// Gets an Int32 or returns null from an object
        /// </summary>
        /// <param name="val">The object to get the value from</param>
        /// <returns>The result of the get</returns>
        int? GetInt32OrNull(object val);

        /// <summary>
        /// Gets an Int64 or returns null from an object
        /// </summary>
        /// <param name="val">The object to get the value from</param>
        /// <returns>The result of the get</returns>
        long? GetInt64OrNull(object val);

        /// <summary>
        /// Gets a boolean or returns false from an object when null
        /// </summary>
        /// <param name="val">The object to get the value from</param>
        /// <returns>The result of the get</returns>
        bool GetSafeBoolean(object val);

        /// <summary>
        /// Gets a value from an object and casts it to the return type
        /// </summary>
        /// <typeparam name="TValue">The type of the value to return</typeparam>
        /// <param name="val">The object to get the value from</param>
        /// <returns>The result of the get</returns>
        TValue GetSafeDatabaseValue<TValue>(object val);

        /// <summary>
        /// Gets a DateTime or returns the default from an object
        /// </summary>
        /// <param name="val">The object to get the value from</param>
        /// <returns>The result of the get</returns>
        DateTime GetSafeDateTime(object val);

        /// <summary>
        /// Gets a decimal or returns the default from an object
        /// </summary>
        /// <param name="val">The object to get the value from</param>
        /// <returns>The result of the get</returns>
        decimal GetSafeDecimal(object val);

        /// <summary>
        /// Gets an Int32 or returns the default from an object
        /// </summary>
        /// <param name="val">The object to get the value from</param>
        /// <returns>The result of the get</returns>
        int GetSafeInt32(object val);

        /// <summary>
        /// Gets an Int64 or returns the default from an object
        /// </summary>
        /// <param name="val">The object to get the value from</param>
        /// <returns>The result of the get</returns>
        long GetSafeInt64(object val);

        /// <summary>
        /// Gets a string or returns the default from an object
        /// </summary>
        /// <param name="val">The object to get the value from</param>
        /// <returns>The result of the get</returns>
        string GetSafeString(object val);

        /// <summary>
        /// Gets a string or returns null from an object
        /// </summary>
        /// <param name="val">The object to get the value from</param>
        /// <returns>The result of the get</returns>
        string GetStringOrNull(object val);

        /// <summary>
        /// Determines if any string in a collection has a value
        /// </summary>
        /// <param name="strings">The collection of strings to determine if any are populated</param>
        /// <returns>Returns <c>true</c> if any string in the collection has a value; otherwise <c>false</c></returns>
        bool IsAnyStringPopulated(params string[] strings);

        /// <summary>
        /// Parses a string to an enum
        /// </summary>
        /// <typeparam name="TResult">The type of enum to cast the input string to</typeparam>
        /// <param name="value">The string to parse</param>
        /// <returns>The result of the parse</returns>
        TResult ParseEnum<TResult>(string value);

        /// <summary>
        /// Serializes an object to XML
        /// </summary>
        /// <param name="o">The object to serialize to a string</param>
        /// <returns>The XML representation of the input object</returns>
        string SerializeToXML(object o);

        /// <summary>
        /// Deserializes XML to an object
        /// </summary>
        /// <typeparam name="TResult">The result of the serialization</typeparam>
        /// <param name="xml">The XML to deserialize</param>
        /// <returns>An object generated from the input XML</returns>
        TResult DeserializeXML<TResult>(string xml);

        /// <summary>
        /// Try to get a value from a DataRow
        /// </summary>
        /// <param name="dataRow">The DataRow to try to get the value from</param>
        /// <param name="columnName">The name of the column to locate in the DataRow</param>
        /// <returns>The value found in the DataRow at the given column name</returns>
        object TryGetValue(DataRow dataRow, string columnName);
    }
}
