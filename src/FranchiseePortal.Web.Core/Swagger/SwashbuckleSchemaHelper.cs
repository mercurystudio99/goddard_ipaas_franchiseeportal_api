using System;
using System.Collections.Generic;
using System.Linq;

namespace FranchiseePortal.Web.Swagger
{
    /// <summary>
    /// Swashbuckle schema helper
    /// </summary>
    /// <see href="https://johnnyreilly.com/swashbuckle-schemaid-already-used#nicer-names-with-swashbuckleschemahelper"/>
    public class SwashbuckleSchemaHelper
    {
        private readonly Dictionary<string, List<string>> _schemaNameRepetition = new();

        // borrowed from https://github.com/domaindrivendev/Swashbuckle.AspNetCore/blob/95cb4d370e08e54eb04cf14e7e6388ca974a686e/src/Swashbuckle.AspNetCore.SwaggerGen/SchemaGenerator/SchemaGeneratorOptions.cs#L44
        private string DefaultSchemaIdSelector(Type modelType)
        {
            if (!modelType.IsConstructedGenericType) return modelType.Name.Replace("[]", "Array");

            var prefix = modelType.GetGenericArguments()
                .Select(genericArg => DefaultSchemaIdSelector(genericArg))
                .Aggregate((previous, current) => previous + current);

            // 20230801RBP - Modified this from the borrowed code because it was changing the
            // of our existing schema.  For example instead of getting "PagedResultDtoOfAuditLogListDto"
            // we would get "AuditLogListDtoPagedResultDto".  This would change type definitions in the client project.
            //return prefix + modelType.Name.Split('`').First();
            return modelType.Name.Split('`').First() + "Of" + prefix;

        }

        public string GetSchemaId(Type modelType)
        {
            string id = DefaultSchemaIdSelector(modelType);

            if (!_schemaNameRepetition.ContainsKey(id))
                _schemaNameRepetition.Add(id, new List<string>());

            var modelNameList = _schemaNameRepetition[id];
            var fullName = modelType.FullName ?? "";
            if (!string.IsNullOrEmpty(fullName) && !modelNameList.Contains(fullName))
                modelNameList.Add(fullName);

            int index = modelNameList.IndexOf(fullName);

            return $"{id}{(index >= 1 ? index.ToString() : "")}";
        }
    }
}
