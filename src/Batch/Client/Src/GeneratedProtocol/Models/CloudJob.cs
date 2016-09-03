// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// An Azure Batch job.
    /// </summary>
    public partial class CloudJob
    {
        /// <summary>
        /// Initializes a new instance of the CloudJob class.
        /// </summary>
        public CloudJob() { }

        /// <summary>
        /// Initializes a new instance of the CloudJob class.
        /// </summary>
        /// <param name="id">A string that uniquely identifies the job within
        /// the account.</param>
        /// <param name="displayName">The display name for the job.</param>
        /// <param name="usesTaskDependencies">The flag that determines if
        /// this job will use tasks with dependencies.</param>
        /// <param name="url">The URL of the job.</param>
        /// <param name="eTag">The ETag of the job.</param>
        /// <param name="lastModified">The last modified time of the
        /// job.</param>
        /// <param name="creationTime">The creation time of the job.</param>
        /// <param name="state">The current state of the job.</param>
        /// <param name="stateTransitionTime">The time at which the job
        /// entered its current state.</param>
        /// <param name="previousState">The previous state of the job.</param>
        /// <param name="previousStateTransitionTime">The time at which the
        /// job entered its previous state.</param>
        /// <param name="priority">The priority of the job.</param>
        /// <param name="constraints">The execution constraints for the
        /// job.</param>
        /// <param name="jobManagerTask">Details of a Job Manager task to be
        /// launched when the job is started.</param>
        /// <param name="jobPreparationTask">The Job Preparation task.</param>
        /// <param name="jobReleaseTask">The Job Release task.</param>
        /// <param name="commonEnvironmentSettings">The list of common
        /// environment variable settings. These environment variables are
        /// set for all tasks in the job (including the Job Manager, Job
        /// Preparation and Job Release tasks).</param>
        /// <param name="poolInfo">The pool on which the Batch service runs
        /// the job's tasks.</param>
        /// <param name="onAllTasksComplete">The action the Batch service
        /// should take when all tasks in the job are in the completed state.
        /// Possible values include: 'noAction', 'terminateJob'</param>
        /// <param name="onTaskFailure">The action the Batch service should
        /// take when any task in the job fails. A task is considered to have
        /// failed if it completes with a non-zero exit code and has
        /// exhausted its retry count, or if it had a scheduling error.
        /// Possible values include: 'noAction',
        /// 'performExitOptionsJobAction'</param>
        /// <param name="metadata">A list of name-value pairs associated with
        /// the job as metadata.</param>
        /// <param name="executionInfo">The execution information for the
        /// job.</param>
        /// <param name="stats">Resource usage statistics for the entire
        /// lifetime of the job.</param>
        public CloudJob(string id = default(string), string displayName = default(string), bool? usesTaskDependencies = default(bool?), string url = default(string), string eTag = default(string), System.DateTime? lastModified = default(System.DateTime?), System.DateTime? creationTime = default(System.DateTime?), JobState? state = default(JobState?), System.DateTime? stateTransitionTime = default(System.DateTime?), JobState? previousState = default(JobState?), System.DateTime? previousStateTransitionTime = default(System.DateTime?), int? priority = default(int?), JobConstraints constraints = default(JobConstraints), JobManagerTask jobManagerTask = default(JobManagerTask), JobPreparationTask jobPreparationTask = default(JobPreparationTask), JobReleaseTask jobReleaseTask = default(JobReleaseTask), System.Collections.Generic.IList<EnvironmentSetting> commonEnvironmentSettings = default(System.Collections.Generic.IList<EnvironmentSetting>), PoolInformation poolInfo = default(PoolInformation), OnAllTasksComplete? onAllTasksComplete = default(OnAllTasksComplete?), OnTaskFailure? onTaskFailure = default(OnTaskFailure?), System.Collections.Generic.IList<MetadataItem> metadata = default(System.Collections.Generic.IList<MetadataItem>), JobExecutionInformation executionInfo = default(JobExecutionInformation), JobStatistics stats = default(JobStatistics))
        {
            Id = id;
            DisplayName = displayName;
            UsesTaskDependencies = usesTaskDependencies;
            Url = url;
            ETag = eTag;
            LastModified = lastModified;
            CreationTime = creationTime;
            State = state;
            StateTransitionTime = stateTransitionTime;
            PreviousState = previousState;
            PreviousStateTransitionTime = previousStateTransitionTime;
            Priority = priority;
            Constraints = constraints;
            JobManagerTask = jobManagerTask;
            JobPreparationTask = jobPreparationTask;
            JobReleaseTask = jobReleaseTask;
            CommonEnvironmentSettings = commonEnvironmentSettings;
            PoolInfo = poolInfo;
            OnAllTasksComplete = onAllTasksComplete;
            OnTaskFailure = onTaskFailure;
            Metadata = metadata;
            ExecutionInfo = executionInfo;
            Stats = stats;
        }

        /// <summary>
        /// Gets or sets a string that uniquely identifies the job within the
        /// account.
        /// </summary>
        /// <remarks>
        /// The id can contain any combination of alphanumeric characters
        /// including hyphens and underscores, and cannot contain more than
        /// 64 characters. It is common to use a GUID for the id.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the display name for the job.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the flag that determines if this job will use tasks
        /// with dependencies.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "usesTaskDependencies")]
        public bool? UsesTaskDependencies { get; set; }

        /// <summary>
        /// Gets or sets the URL of the job.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the ETag of the job.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "eTag")]
        public string ETag { get; set; }

        /// <summary>
        /// Gets or sets the last modified time of the job.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastModified")]
        public System.DateTime? LastModified { get; set; }

        /// <summary>
        /// Gets or sets the creation time of the job.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "creationTime")]
        public System.DateTime? CreationTime { get; set; }

        /// <summary>
        /// Gets or sets the current state of the job.
        /// </summary>
        /// <remarks>
        /// Possible values include: 'active', 'disabling', 'disabled',
        /// 'enabling', 'terminating', 'completed', 'deleting'
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "state")]
        public JobState? State { get; set; }

        /// <summary>
        /// Gets or sets the time at which the job entered its current state.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "stateTransitionTime")]
        public System.DateTime? StateTransitionTime { get; set; }

        /// <summary>
        /// Gets or sets the previous state of the job.
        /// </summary>
        /// <remarks>
        /// This property is not set if the job is in its initial Active
        /// state. Possible values include: 'active', 'disabling',
        /// 'disabled', 'enabling', 'terminating', 'completed', 'deleting'
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "previousState")]
        public JobState? PreviousState { get; set; }

        /// <summary>
        /// Gets or sets the time at which the job entered its previous state.
        /// </summary>
        /// <remarks>
        /// This property is not set if the job is in its initial Active state.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "previousStateTransitionTime")]
        public System.DateTime? PreviousStateTransitionTime { get; set; }

        /// <summary>
        /// Gets or sets the priority of the job.
        /// </summary>
        /// <remarks>
        /// Priority values can range from -1000 to 1000, with -1000 being
        /// the lowest priority and 1000 being the highest priority. The
        /// default value is 0.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or sets the execution constraints for the job.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "constraints")]
        public JobConstraints Constraints { get; set; }

        /// <summary>
        /// Gets or sets details of a Job Manager task to be launched when the
        /// job is started.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "jobManagerTask")]
        public JobManagerTask JobManagerTask { get; set; }

        /// <summary>
        /// Gets or sets the Job Preparation task.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "jobPreparationTask")]
        public JobPreparationTask JobPreparationTask { get; set; }

        /// <summary>
        /// Gets or sets the Job Release task.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "jobReleaseTask")]
        public JobReleaseTask JobReleaseTask { get; set; }

        /// <summary>
        /// Gets or sets the list of common environment variable settings.
        /// These environment variables are set for all tasks in the job
        /// (including the Job Manager, Job Preparation and Job Release
        /// tasks).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "commonEnvironmentSettings")]
        public System.Collections.Generic.IList<EnvironmentSetting> CommonEnvironmentSettings { get; set; }

        /// <summary>
        /// Gets or sets the pool on which the Batch service runs the job's
        /// tasks.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "poolInfo")]
        public PoolInformation PoolInfo { get; set; }

        /// <summary>
        /// Gets or sets the action the Batch service should take when all
        /// tasks in the job are in the completed state. Possible values
        /// include: 'noAction', 'terminateJob'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "onAllTasksComplete")]
        public OnAllTasksComplete? OnAllTasksComplete { get; set; }

        /// <summary>
        /// Gets or sets the action the Batch service should take when any
        /// task in the job fails. A task is considered to have failed if it
        /// completes with a non-zero exit code and has exhausted its retry
        /// count, or if it had a scheduling error. Possible values include:
        /// 'noAction', 'performExitOptionsJobAction'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "onTaskFailure")]
        public OnTaskFailure? OnTaskFailure { get; set; }

        /// <summary>
        /// Gets or sets a list of name-value pairs associated with the job as
        /// metadata.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "metadata")]
        public System.Collections.Generic.IList<MetadataItem> Metadata { get; set; }

        /// <summary>
        /// Gets or sets the execution information for the job.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "executionInfo")]
        public JobExecutionInformation ExecutionInfo { get; set; }

        /// <summary>
        /// Gets or sets resource usage statistics for the entire lifetime of
        /// the job.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "stats")]
        public JobStatistics Stats { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.JobManagerTask != null)
            {
                this.JobManagerTask.Validate();
            }
            if (this.JobPreparationTask != null)
            {
                this.JobPreparationTask.Validate();
            }
            if (this.JobReleaseTask != null)
            {
                this.JobReleaseTask.Validate();
            }
            if (this.CommonEnvironmentSettings != null)
            {
                foreach (var element in this.CommonEnvironmentSettings)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.PoolInfo != null)
            {
                this.PoolInfo.Validate();
            }
            if (this.Metadata != null)
            {
                foreach (var element1 in this.Metadata)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (this.ExecutionInfo != null)
            {
                this.ExecutionInfo.Validate();
            }
            if (this.Stats != null)
            {
                this.Stats.Validate();
            }
        }
    }
}
