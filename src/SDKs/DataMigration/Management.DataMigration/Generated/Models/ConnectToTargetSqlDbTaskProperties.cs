// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties for the task that validates connection to SQL DB and target
    /// server requirements
    /// </summary>
    [Newtonsoft.Json.JsonObject("ConnectToTarget.SqlDb")]
    public partial class ConnectToTargetSqlDbTaskProperties : ProjectTaskProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ConnectToTargetSqlDbTaskProperties class.
        /// </summary>
        public ConnectToTargetSqlDbTaskProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ConnectToTargetSqlDbTaskProperties class.
        /// </summary>
        /// <param name="errors">Array of errors. This is ignored if
        /// submitted.</param>
        /// <param name="state">The state of the task. This is ignored if
        /// submitted. Possible values include: 'Unknown', 'Queued', 'Running',
        /// 'Canceled', 'Succeeded', 'Failed', 'FailedInputValidation',
        /// 'Faulted'</param>
        /// <param name="input">Task input</param>
        /// <param name="output">Task output. This is ignored if
        /// submitted.</param>
        public ConnectToTargetSqlDbTaskProperties(IList<ODataError> errors = default(IList<ODataError>), TaskState? state = default(TaskState?), ConnectToTargetSqlDbTaskInput input = default(ConnectToTargetSqlDbTaskInput), IList<ConnectToTargetSqlDbTaskOutput> output = default(IList<ConnectToTargetSqlDbTaskOutput>))
            : base(errors, state)
        {
            Input = input;
            Output = output;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets task input
        /// </summary>
        [JsonProperty(PropertyName = "input")]
        public ConnectToTargetSqlDbTaskInput Input { get; set; }

        /// <summary>
        /// Gets task output. This is ignored if submitted.
        /// </summary>
        [JsonProperty(PropertyName = "output")]
        public IList<ConnectToTargetSqlDbTaskOutput> Output { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Input != null)
            {
                Input.Validate();
            }
        }
    }
}