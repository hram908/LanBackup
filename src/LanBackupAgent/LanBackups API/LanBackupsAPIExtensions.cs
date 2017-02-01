﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace LanBackupAgent
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Extension methods for LanBackupsAPI.
    /// </summary>
    public static partial class LanBackupsAPIExtensions
    {
            /// <summary>
            /// retrieve all  backup configurations
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='idx'>
            /// </param>
            /// <param name='siz'>
            /// </param>
            public static PaginatedListBackupConfigurationString ApiBackupConfigGet(this ILanBackupsAPI operations, string idx = default(string), string siz = default(string))
            {
                return Task.Factory.StartNew(s => ((ILanBackupsAPI)s).ApiBackupConfigGetAsync(idx, siz), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// retrieve all  backup configurations
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='idx'>
            /// </param>
            /// <param name='siz'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PaginatedListBackupConfigurationString> ApiBackupConfigGetAsync(this ILanBackupsAPI operations, string idx = default(string), string siz = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiBackupConfigGetWithHttpMessagesAsync(idx, siz, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// create backup configuration
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='backup'>
            /// </param>
            public static BackupConfiguration ApiBackupConfigPost(this ILanBackupsAPI operations, BackupConfiguration backup = default(BackupConfiguration))
            {
                return Task.Factory.StartNew(s => ((ILanBackupsAPI)s).ApiBackupConfigPostAsync(backup), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// create backup configuration
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='backup'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BackupConfiguration> ApiBackupConfigPostAsync(this ILanBackupsAPI operations, BackupConfiguration backup = default(BackupConfiguration), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiBackupConfigPostWithHttpMessagesAsync(backup, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// retrieve backup configuration by ID
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static BackupConfiguration ApiBackupConfigByIdGet(this ILanBackupsAPI operations, string id)
            {
                return Task.Factory.StartNew(s => ((ILanBackupsAPI)s).ApiBackupConfigByIdGetAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// retrieve backup configuration by ID
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BackupConfiguration> ApiBackupConfigByIdGetAsync(this ILanBackupsAPI operations, string id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiBackupConfigByIdGetWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update backup configuration
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='backup'>
            /// </param>
            public static BackupConfiguration ApiBackupConfigByIdPut(this ILanBackupsAPI operations, string id, BackupConfiguration backup = default(BackupConfiguration))
            {
                return Task.Factory.StartNew(s => ((ILanBackupsAPI)s).ApiBackupConfigByIdPutAsync(id, backup), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update backup configuration
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='backup'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BackupConfiguration> ApiBackupConfigByIdPutAsync(this ILanBackupsAPI operations, string id, BackupConfiguration backup = default(BackupConfiguration), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiBackupConfigByIdPutWithHttpMessagesAsync(id, backup, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// delete backup configuration by id
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static object ApiBackupConfigByIdDelete(this ILanBackupsAPI operations, string id)
            {
                return Task.Factory.StartNew(s => ((ILanBackupsAPI)s).ApiBackupConfigByIdDeleteAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// delete backup configuration by id
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> ApiBackupConfigByIdDeleteAsync(this ILanBackupsAPI operations, string id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiBackupConfigByIdDeleteWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// retrieve backup configuration by ID
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='clientid'>
            /// </param>
            public static IList<BackupConfiguration> ApiBackupConfigClientByClientidGet(this ILanBackupsAPI operations, string clientid)
            {
                return Task.Factory.StartNew(s => ((ILanBackupsAPI)s).ApiBackupConfigClientByClientidGetAsync(clientid), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// retrieve backup configuration by ID
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='clientid'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<BackupConfiguration>> ApiBackupConfigClientByClientidGetAsync(this ILanBackupsAPI operations, string clientid, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiBackupConfigClientByClientidGetWithHttpMessagesAsync(clientid, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// retrieves paginated logs from DB
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='idx'>
            /// page index
            /// </param>
            /// <param name='siz'>
            /// page size
            /// </param>
            public static PaginatedListBackupLogDateTime ApiLogsGet(this ILanBackupsAPI operations, string idx = default(string), string siz = default(string))
            {
                return Task.Factory.StartNew(s => ((ILanBackupsAPI)s).ApiLogsGetAsync(idx, siz), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// retrieves paginated logs from DB
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='idx'>
            /// page index
            /// </param>
            /// <param name='siz'>
            /// page size
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PaginatedListBackupLogDateTime> ApiLogsGetAsync(this ILanBackupsAPI operations, string idx = default(string), string siz = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiLogsGetWithHttpMessagesAsync(idx, siz, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create an entry in the logs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='log'>
            /// </param>
            public static object ApiLogsPost(this ILanBackupsAPI operations, BackupLog log = default(BackupLog))
            {
                return Task.Factory.StartNew(s => ((ILanBackupsAPI)s).ApiLogsPostAsync(log), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create an entry in the logs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='log'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> ApiLogsPostAsync(this ILanBackupsAPI operations, BackupLog log = default(BackupLog), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiLogsPostWithHttpMessagesAsync(log, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// retrieves alog record by ID
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static BackupLog ApiLogsByIdGet(this ILanBackupsAPI operations, int id)
            {
                return Task.Factory.StartNew(s => ((ILanBackupsAPI)s).ApiLogsByIdGetAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// retrieves alog record by ID
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BackupLog> ApiLogsByIdGetAsync(this ILanBackupsAPI operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiLogsByIdGetWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// retrieve all logs of a clientIP
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='clientid'>
            /// </param>
            public static IList<BackupLog> ApiLogsClientByClientidGet(this ILanBackupsAPI operations, string clientid)
            {
                return Task.Factory.StartNew(s => ((ILanBackupsAPI)s).ApiLogsClientByClientidGetAsync(clientid), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// retrieve all logs of a clientIP
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='clientid'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<BackupLog>> ApiLogsClientByClientidGetAsync(this ILanBackupsAPI operations, string clientid, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiLogsClientByClientidGetWithHttpMessagesAsync(clientid, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// retrieves all logs of a specific configuration
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='configurationid'>
            /// </param>
            public static IList<BackupLog> ApiLogsConfigByConfigurationidGet(this ILanBackupsAPI operations, string configurationid)
            {
                return Task.Factory.StartNew(s => ((ILanBackupsAPI)s).ApiLogsConfigByConfigurationidGetAsync(configurationid), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// retrieves all logs of a specific configuration
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='configurationid'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<BackupLog>> ApiLogsConfigByConfigurationidGetAsync(this ILanBackupsAPI operations, string configurationid, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiLogsConfigByConfigurationidGetWithHttpMessagesAsync(configurationid, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dtouser'>
            /// </param>
            public static IdentityResult ApiUsersRegisterPost(this ILanBackupsAPI operations, User dtouser = default(User))
            {
                return Task.Factory.StartNew(s => ((ILanBackupsAPI)s).ApiUsersRegisterPostAsync(dtouser), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dtouser'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IdentityResult> ApiUsersRegisterPostAsync(this ILanBackupsAPI operations, User dtouser = default(User), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiUsersRegisterPostWithHttpMessagesAsync(dtouser, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dtouser'>
            /// </param>
            public static void ApiUsersLoginPost(this ILanBackupsAPI operations, User dtouser = default(User))
            {
                Task.Factory.StartNew(s => ((ILanBackupsAPI)s).ApiUsersLoginPostAsync(dtouser), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dtouser'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiUsersLoginPostAsync(this ILanBackupsAPI operations, User dtouser = default(User), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ApiUsersLoginPostWithHttpMessagesAsync(dtouser, null, cancellationToken).ConfigureAwait(false);
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dtouser'>
            /// </param>
            public static void ApiUsersPwchangePost(this ILanBackupsAPI operations, User dtouser = default(User))
            {
                Task.Factory.StartNew(s => ((ILanBackupsAPI)s).ApiUsersPwchangePostAsync(dtouser), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dtouser'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiUsersPwchangePostAsync(this ILanBackupsAPI operations, User dtouser = default(User), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ApiUsersPwchangePostWithHttpMessagesAsync(dtouser, null, cancellationToken).ConfigureAwait(false);
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void ApiUsersListGet(this ILanBackupsAPI operations)
            {
                Task.Factory.StartNew(s => ((ILanBackupsAPI)s).ApiUsersListGetAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiUsersListGetAsync(this ILanBackupsAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ApiUsersListGetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='user'>
            /// </param>
            public static void ApiUsersListPost(this ILanBackupsAPI operations, User user = default(User))
            {
                Task.Factory.StartNew(s => ((ILanBackupsAPI)s).ApiUsersListPostAsync(user), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='user'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiUsersListPostAsync(this ILanBackupsAPI operations, User user = default(User), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ApiUsersListPostWithHttpMessagesAsync(user, null, cancellationToken).ConfigureAwait(false);
            }

    }
}
