﻿namespace MareSynchronos.API.Routes;

public class MareFiles
{
    public const string Cache = "/cache";
    public const string Cache_Get = "get";
    public const string Request = "/request";

    public const string Request_Cancel = "cancel";

    public const string Request_Check = "check";

    public const string Request_Enqueue = "enqueue";

    public const string Request_RequestFile = "file";

    public const string ServerFiles = "/files";

    public const string ServerFiles_DeleteAll = "deleteAll";

    public const string ServerFiles_FilesSend = "filesSend";

    public const string ServerFiles_Get = "get";

    public const string ServerFiles_GetSizes = "getFileSizes";

    public const string ServerFiles_Upload = "upload";

    public const string ServerFiles_UploadRaw = "uploadRaw";

    public static Uri CacheGetFullPath(Uri baseUri, Guid requestId) => new(baseUri, Cache + "/" + Cache_Get + "?requestId=" + requestId.ToString());

    public static Uri RequestCancelFullPath(Uri baseUri, Guid guid) => new Uri(baseUri, Request + "/" + Request_Cancel + "?requestId=" + guid.ToString());

    public static Uri RequestCheckQueueFullPath(Uri baseUri, Guid guid) => new Uri(baseUri, Request + "/" + Request_Check + "?requestId=" + guid.ToString());

    public static Uri RequestEnqueueFullPath(Uri baseUri) => new(baseUri, Request + "/" + Request_Enqueue);

    public static Uri RequestRequestFileFullPath(Uri baseUri, string hash) => new(baseUri, Request + "/" + Request_RequestFile + "?file=" + hash);

    public static Uri ServerFilesDeleteAllFullPath(Uri baseUri) => new(baseUri, ServerFiles + "/" + ServerFiles_DeleteAll);

    public static Uri ServerFilesFilesSendFullPath(Uri baseUri) => new(baseUri, ServerFiles + "/" + ServerFiles_FilesSend);

    public static Uri ServerFilesGetFullPath(Uri baseUri, string hash) => new(baseUri, ServerFiles + "/" + ServerFiles_Get + "/" + hash);

    public static Uri ServerFilesGetSizesFullPath(Uri baseUri) => new(baseUri, ServerFiles + "/" + ServerFiles_GetSizes);

    public static Uri ServerFilesUploadFullPath(Uri baseUri, string hash) => new(baseUri, ServerFiles + "/" + ServerFiles_Upload + "/" + hash);

    public static Uri ServerFilesUploadRawFullPath(Uri baseUri, string hash) => new(baseUri, ServerFiles + "/" + ServerFiles_UploadRaw + "/" + hash);
}