using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace PureCloudPlatform.Client.V2.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IConversationsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete a code used to add a communication to this participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="addCommunicationCode">addCommunicationCode</param>
        /// <returns></returns>
        void DeleteConversationParticipantCode (string conversationId, string participantId, string addCommunicationCode);

        /// <summary>
        /// Delete a code used to add a communication to this participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="addCommunicationCode">addCommunicationCode</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteConversationParticipantCodeWithHttpInfo (string conversationId, string participantId, string addCommunicationCode);
        /// <summary>
        /// Cancel the transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>string</returns>
        string DeleteConversationsCallParticipantConsult (string conversationId, string participantId);

        /// <summary>
        /// Cancel the transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteConversationsCallParticipantConsultWithHttpInfo (string conversationId, string participantId);
        /// <summary>
        /// Delete attachment from draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="attachmentId">attachmentId</param>
        /// <returns>string</returns>
        string DeleteConversationsEmailMessagesDraftAttachment (string conversationId, string attachmentId);

        /// <summary>
        /// Delete attachment from draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="attachmentId">attachmentId</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteConversationsEmailMessagesDraftAttachmentWithHttpInfo (string conversationId, string attachmentId);
        /// <summary>
        /// Get a conversation by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>AnalyticsConversation</returns>
        AnalyticsConversation GetAnalyticsConversationDetails (string conversationId);

        /// <summary>
        /// Get a conversation by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>ApiResponse of AnalyticsConversation</returns>
        ApiResponse<AnalyticsConversation> GetAnalyticsConversationDetailsWithHttpInfo (string conversationId);
        /// <summary>
        /// Get conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Conversation</returns>
        Conversation GetConversation (string conversationId);

        /// <summary>
        /// Get conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>ApiResponse of Conversation</returns>
        ApiResponse<Conversation> GetConversationWithHttpInfo (string conversationId);
        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>WrapupCode</returns>
        WrapupCode GetConversationParticipantWrapup (string conversationId, string participantId, bool? provisional = null);

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        ApiResponse<WrapupCode> GetConversationParticipantWrapupWithHttpInfo (string conversationId, string participantId, bool? provisional = null);
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>List&lt;WrapupCode&gt;</returns>
        List<WrapupCode> GetConversationParticipantWrapupcodes (string conversationId, string participantId);

        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>ApiResponse of List&lt;WrapupCode&gt;</returns>
        ApiResponse<List<WrapupCode>> GetConversationParticipantWrapupcodesWithHttpInfo (string conversationId, string participantId);
        /// <summary>
        /// Get conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="communicationType">Call or Chat communication filtering (optional)</param>
        /// <returns>ConversationEntityListing</returns>
        ConversationEntityListing GetConversations (string communicationType = null);

        /// <summary>
        /// Get conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="communicationType">Call or Chat communication filtering (optional)</param>
        /// <returns>ApiResponse of ConversationEntityListing</returns>
        ApiResponse<ConversationEntityListing> GetConversationsWithHttpInfo (string communicationType = null);
        /// <summary>
        /// Get call conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>CallConversation</returns>
        CallConversation GetConversationsCall (string conversationId);

        /// <summary>
        /// Get call conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>ApiResponse of CallConversation</returns>
        ApiResponse<CallConversation> GetConversationsCallWithHttpInfo (string conversationId);
        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Wrapup</returns>
        Wrapup GetConversationsCallParticipantWrapup (string conversationId, string participantId, bool? provisional = null);

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>ApiResponse of Wrapup</returns>
        ApiResponse<Wrapup> GetConversationsCallParticipantWrapupWithHttpInfo (string conversationId, string participantId, bool? provisional = null);
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>List&lt;WrapupCode&gt;</returns>
        List<WrapupCode> GetConversationsCallParticipantWrapupcodes (string conversationId, string participantId);

        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>ApiResponse of List&lt;WrapupCode&gt;</returns>
        ApiResponse<List<WrapupCode>> GetConversationsCallParticipantWrapupcodesWithHttpInfo (string conversationId, string participantId);
        /// <summary>
        /// Get callback conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>CallbackConversation</returns>
        CallbackConversation GetConversationsCallback (string conversationId);

        /// <summary>
        /// Get callback conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>ApiResponse of CallbackConversation</returns>
        ApiResponse<CallbackConversation> GetConversationsCallbackWithHttpInfo (string conversationId);
        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Wrapup</returns>
        Wrapup GetConversationsCallbackParticipantWrapup (string conversationId, string participantId, bool? provisional = null);

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>ApiResponse of Wrapup</returns>
        ApiResponse<Wrapup> GetConversationsCallbackParticipantWrapupWithHttpInfo (string conversationId, string participantId, bool? provisional = null);
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>List&lt;WrapupCode&gt;</returns>
        List<WrapupCode> GetConversationsCallbackParticipantWrapupcodes (string conversationId, string participantId);

        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>ApiResponse of List&lt;WrapupCode&gt;</returns>
        ApiResponse<List<WrapupCode>> GetConversationsCallbackParticipantWrapupcodesWithHttpInfo (string conversationId, string participantId);
        /// <summary>
        /// Get callback conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CallbackConversationEntityListing</returns>
        CallbackConversationEntityListing GetConversationsCallbacks ();

        /// <summary>
        /// Get callback conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CallbackConversationEntityListing</returns>
        ApiResponse<CallbackConversationEntityListing> GetConversationsCallbacksWithHttpInfo ();
        /// <summary>
        /// Get recent conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CallConversationEntityListing</returns>
        CallConversationEntityListing GetConversationsCalls ();

        /// <summary>
        /// Get recent conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CallConversationEntityListing</returns>
        ApiResponse<CallConversationEntityListing> GetConversationsCallsWithHttpInfo ();
        /// <summary>
        /// Get call history
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="interval">Interval string; format is ISO-8601. Separate start and end times with forward slash &#39;/&#39; (optional)</param>
        /// <returns>CallConversationEntityListing</returns>
        CallConversationEntityListing GetConversationsCallsHistory (int? pageSize = null, int? pageNumber = null, string interval = null);

        /// <summary>
        /// Get call history
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="interval">Interval string; format is ISO-8601. Separate start and end times with forward slash &#39;/&#39; (optional)</param>
        /// <returns>ApiResponse of CallConversationEntityListing</returns>
        ApiResponse<CallConversationEntityListing> GetConversationsCallsHistoryWithHttpInfo (int? pageSize = null, int? pageNumber = null, string interval = null);
        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>MaxParticipants</returns>
        MaxParticipants GetConversationsCallsMaximumconferenceparties ();

        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of MaxParticipants</returns>
        ApiResponse<MaxParticipants> GetConversationsCallsMaximumconferencepartiesWithHttpInfo ();
        /// <summary>
        /// Get chat conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>ChatConversation</returns>
        ChatConversation GetConversationsChat (string conversationId);

        /// <summary>
        /// Get chat conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>ApiResponse of ChatConversation</returns>
        ApiResponse<ChatConversation> GetConversationsChatWithHttpInfo (string conversationId);
        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Wrapup</returns>
        Wrapup GetConversationsChatParticipantWrapup (string conversationId, string participantId, bool? provisional = null);

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>ApiResponse of Wrapup</returns>
        ApiResponse<Wrapup> GetConversationsChatParticipantWrapupWithHttpInfo (string conversationId, string participantId, bool? provisional = null);
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>List&lt;WrapupCode&gt;</returns>
        List<WrapupCode> GetConversationsChatParticipantWrapupcodes (string conversationId, string participantId);

        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>ApiResponse of List&lt;WrapupCode&gt;</returns>
        ApiResponse<List<WrapupCode>> GetConversationsChatParticipantWrapupcodesWithHttpInfo (string conversationId, string participantId);
        /// <summary>
        /// Get recent chat conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ChatConversationEntityListing</returns>
        ChatConversationEntityListing GetConversationsChats ();

        /// <summary>
        /// Get recent chat conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ChatConversationEntityListing</returns>
        ApiResponse<ChatConversationEntityListing> GetConversationsChatsWithHttpInfo ();
        /// <summary>
        /// Get cobrowse conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>CobrowseConversation</returns>
        CobrowseConversation GetConversationsCobrowsesession (string conversationId);

        /// <summary>
        /// Get cobrowse conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>ApiResponse of CobrowseConversation</returns>
        ApiResponse<CobrowseConversation> GetConversationsCobrowsesessionWithHttpInfo (string conversationId);
        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Wrapup</returns>
        Wrapup GetConversationsCobrowsesessionParticipantWrapup (string conversationId, string participantId, bool? provisional = null);

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>ApiResponse of Wrapup</returns>
        ApiResponse<Wrapup> GetConversationsCobrowsesessionParticipantWrapupWithHttpInfo (string conversationId, string participantId, bool? provisional = null);
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>List&lt;WrapupCode&gt;</returns>
        List<WrapupCode> GetConversationsCobrowsesessionParticipantWrapupcodes (string conversationId, string participantId);

        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>ApiResponse of List&lt;WrapupCode&gt;</returns>
        ApiResponse<List<WrapupCode>> GetConversationsCobrowsesessionParticipantWrapupcodesWithHttpInfo (string conversationId, string participantId);
        /// <summary>
        /// Get recent cobrowse conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CobrowseConversationEntityListing</returns>
        CobrowseConversationEntityListing GetConversationsCobrowsesessions ();

        /// <summary>
        /// Get recent cobrowse conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CobrowseConversationEntityListing</returns>
        ApiResponse<CobrowseConversationEntityListing> GetConversationsCobrowsesessionsWithHttpInfo ();
        /// <summary>
        /// Get email conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>EmailConversation</returns>
        EmailConversation GetConversationsEmail (string conversationId);

        /// <summary>
        /// Get email conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>ApiResponse of EmailConversation</returns>
        ApiResponse<EmailConversation> GetConversationsEmailWithHttpInfo (string conversationId);
        /// <summary>
        /// Get conversation message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>EmailMessage</returns>
        EmailMessage GetConversationsEmailMessage (string conversationId, string messageId);

        /// <summary>
        /// Get conversation message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        ApiResponse<EmailMessage> GetConversationsEmailMessageWithHttpInfo (string conversationId, string messageId);
        /// <summary>
        /// Get conversation messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>EmailMessageListing</returns>
        EmailMessageListing GetConversationsEmailMessages (string conversationId);

        /// <summary>
        /// Get conversation messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>ApiResponse of EmailMessageListing</returns>
        ApiResponse<EmailMessageListing> GetConversationsEmailMessagesWithHttpInfo (string conversationId);
        /// <summary>
        /// Get conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>EmailMessage</returns>
        EmailMessage GetConversationsEmailMessagesDraft (string conversationId);

        /// <summary>
        /// Get conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        ApiResponse<EmailMessage> GetConversationsEmailMessagesDraftWithHttpInfo (string conversationId);
        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Wrapup</returns>
        Wrapup GetConversationsEmailParticipantWrapup (string conversationId, string participantId, bool? provisional = null);

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>ApiResponse of Wrapup</returns>
        ApiResponse<Wrapup> GetConversationsEmailParticipantWrapupWithHttpInfo (string conversationId, string participantId, bool? provisional = null);
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>List&lt;WrapupCode&gt;</returns>
        List<WrapupCode> GetConversationsEmailParticipantWrapupcodes (string conversationId, string participantId);

        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>ApiResponse of List&lt;WrapupCode&gt;</returns>
        ApiResponse<List<WrapupCode>> GetConversationsEmailParticipantWrapupcodesWithHttpInfo (string conversationId, string participantId);
        /// <summary>
        /// Get recent email conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>EmailConversationEntityListing</returns>
        EmailConversationEntityListing GetConversationsEmails ();

        /// <summary>
        /// Get recent email conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of EmailConversationEntityListing</returns>
        ApiResponse<EmailConversationEntityListing> GetConversationsEmailsWithHttpInfo ();
        /// <summary>
        /// Update a participant.
        /// </summary>
        /// <remarks>
        /// Update conversation participant.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Update request</param>
        /// <returns></returns>
        void PatchConversationParticipant (string conversationId, string participantId, MediaParticipantRequest body);

        /// <summary>
        /// Update a participant.
        /// </summary>
        /// <remarks>
        /// Update conversation participant.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Update request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchConversationParticipantWithHttpInfo (string conversationId, string participantId, MediaParticipantRequest body);
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Participant attributes</param>
        /// <returns></returns>
        void PatchConversationParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body);

        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchConversationParticipantAttributesWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body);
        /// <summary>
        /// Update a conversation by setting it&#39;s recording state, merging in other conversations to create a conference, or disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        Conversation PatchConversationsCall (string conversationId, Conversation body);

        /// <summary>
        /// Update a conversation by setting it&#39;s recording state, merging in other conversations to create a conference, or disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        ApiResponse<Conversation> PatchConversationsCallWithHttpInfo (string conversationId, Conversation body);
        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant request</param>
        /// <returns></returns>
        void PatchConversationsCallParticipant (string conversationId, string participantId, MediaParticipantRequest body);

        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchConversationsCallParticipantWithHttpInfo (string conversationId, string participantId, MediaParticipantRequest body);
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns></returns>
        void PatchConversationsCallParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body);

        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchConversationsCallParticipantAttributesWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body);
        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Empty</returns>
        Empty PatchConversationsCallParticipantCommunication (string conversationId, string participantId, string communicationId, MediaParticipantRequest body);

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>ApiResponse of Empty</returns>
        ApiResponse<Empty> PatchConversationsCallParticipantCommunicationWithHttpInfo (string conversationId, string participantId, string communicationId, MediaParticipantRequest body);
        /// <summary>
        /// Change who can speak
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">new speak to</param>
        /// <returns>ConsultTransferResponse</returns>
        ConsultTransferResponse PatchConversationsCallParticipantConsult (string conversationId, string participantId, ConsultTransferUpdate body);

        /// <summary>
        /// Change who can speak
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">new speak to</param>
        /// <returns>ApiResponse of ConsultTransferResponse</returns>
        ApiResponse<ConsultTransferResponse> PatchConversationsCallParticipantConsultWithHttpInfo (string conversationId, string participantId, ConsultTransferUpdate body);
        /// <summary>
        /// Update a conversation by disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        Conversation PatchConversationsCallback (string conversationId, Conversation body);

        /// <summary>
        /// Update a conversation by disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        ApiResponse<Conversation> PatchConversationsCallbackWithHttpInfo (string conversationId, Conversation body);
        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant</param>
        /// <returns></returns>
        void PatchConversationsCallbackParticipant (string conversationId, string participantId, MediaParticipantRequest body);

        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchConversationsCallbackParticipantWithHttpInfo (string conversationId, string participantId, MediaParticipantRequest body);
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Attributes</param>
        /// <returns></returns>
        void PatchConversationsCallbackParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body);

        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Attributes</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchConversationsCallbackParticipantAttributesWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body);
        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Empty</returns>
        Empty PatchConversationsCallbackParticipantCommunication (string conversationId, string participantId, string communicationId, MediaParticipantRequest body);

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>ApiResponse of Empty</returns>
        ApiResponse<Empty> PatchConversationsCallbackParticipantCommunicationWithHttpInfo (string conversationId, string participantId, string communicationId, MediaParticipantRequest body);
        /// <summary>
        /// Update a conversation by disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        Conversation PatchConversationsChat (string conversationId, Conversation body);

        /// <summary>
        /// Update a conversation by disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        ApiResponse<Conversation> PatchConversationsChatWithHttpInfo (string conversationId, Conversation body);
        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Update request</param>
        /// <returns></returns>
        void PatchConversationsChatParticipant (string conversationId, string participantId, MediaParticipantRequest body);

        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Update request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchConversationsChatParticipantWithHttpInfo (string conversationId, string participantId, MediaParticipantRequest body);
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns></returns>
        void PatchConversationsChatParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body);

        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchConversationsChatParticipantAttributesWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body);
        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Empty</returns>
        Empty PatchConversationsChatParticipantCommunication (string conversationId, string participantId, string communicationId, MediaParticipantRequest body);

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>ApiResponse of Empty</returns>
        ApiResponse<Empty> PatchConversationsChatParticipantCommunicationWithHttpInfo (string conversationId, string participantId, string communicationId, MediaParticipantRequest body);
        /// <summary>
        /// Update a conversation by disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        Conversation PatchConversationsCobrowsesession (string conversationId, Conversation body);

        /// <summary>
        /// Update a conversation by disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        ApiResponse<Conversation> PatchConversationsCobrowsesessionWithHttpInfo (string conversationId, Conversation body);
        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        void PatchConversationsCobrowsesessionParticipant (string conversationId, string participantId, MediaParticipantRequest body = null);

        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchConversationsCobrowsesessionParticipantWithHttpInfo (string conversationId, string participantId, MediaParticipantRequest body = null);
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        void PatchConversationsCobrowsesessionParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body = null);

        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchConversationsCobrowsesessionParticipantAttributesWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body = null);
        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Empty</returns>
        Empty PatchConversationsCobrowsesessionParticipantCommunication (string conversationId, string participantId, string communicationId, MediaParticipantRequest body);

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>ApiResponse of Empty</returns>
        ApiResponse<Empty> PatchConversationsCobrowsesessionParticipantCommunicationWithHttpInfo (string conversationId, string participantId, string communicationId, MediaParticipantRequest body);
        /// <summary>
        /// Update a conversation by disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        Conversation PatchConversationsEmail (string conversationId, Conversation body);

        /// <summary>
        /// Update a conversation by disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        ApiResponse<Conversation> PatchConversationsEmailWithHttpInfo (string conversationId, Conversation body);
        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Update request</param>
        /// <returns></returns>
        void PatchConversationsEmailParticipant (string conversationId, string participantId, MediaParticipantRequest body);

        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Update request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchConversationsEmailParticipantWithHttpInfo (string conversationId, string participantId, MediaParticipantRequest body);
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns></returns>
        void PatchConversationsEmailParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body);

        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchConversationsEmailParticipantAttributesWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body);
        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Empty</returns>
        Empty PatchConversationsEmailParticipantCommunication (string conversationId, string participantId, string communicationId, MediaParticipantRequest body);

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>ApiResponse of Empty</returns>
        ApiResponse<Empty> PatchConversationsEmailParticipantCommunicationWithHttpInfo (string conversationId, string participantId, string communicationId, MediaParticipantRequest body);
        /// <summary>
        /// Index conversation properties
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">request</param>
        /// <returns>PropertyIndexRequest</returns>
        PropertyIndexRequest PostAnalyticsConversationDetailsProperties (string conversationId, PropertyIndexRequest body);

        /// <summary>
        /// Index conversation properties
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">request</param>
        /// <returns>ApiResponse of PropertyIndexRequest</returns>
        ApiResponse<PropertyIndexRequest> PostAnalyticsConversationDetailsPropertiesWithHttpInfo (string conversationId, PropertyIndexRequest body);
        /// <summary>
        /// Query for conversation aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>AggregateQueryResponse</returns>
        AggregateQueryResponse PostAnalyticsConversationsAggregatesQuery (AggregationQuery body);

        /// <summary>
        /// Query for conversation aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of AggregateQueryResponse</returns>
        ApiResponse<AggregateQueryResponse> PostAnalyticsConversationsAggregatesQueryWithHttpInfo (AggregationQuery body);
        /// <summary>
        /// Query for conversation details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>AnalyticsConversationQueryResponse</returns>
        AnalyticsConversationQueryResponse PostAnalyticsConversationsDetailsQuery (ConversationQuery body);

        /// <summary>
        /// Query for conversation details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of AnalyticsConversationQueryResponse</returns>
        ApiResponse<AnalyticsConversationQueryResponse> PostAnalyticsConversationsDetailsQueryWithHttpInfo (ConversationQuery body);
        /// <summary>
        /// Create a new callback for the specified participant on the conversation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        void PostConversationParticipantCallbacks (string conversationId, string participantId, CreateCallbackCommand body = null);

        /// <summary>
        /// Create a new callback for the specified participant on the conversation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostConversationParticipantCallbacksWithHttpInfo (string conversationId, string participantId, CreateCallbackCommand body = null);
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Transfer request</param>
        /// <returns></returns>
        void PostConversationParticipantReplace (string conversationId, string participantId, TransferRequest body);

        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Transfer request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostConversationParticipantReplaceWithHttpInfo (string conversationId, string participantId, TransferRequest body);
        /// <summary>
        /// Add a new call to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        Conversation PostConversationsCall (string conversationId, CallCommand body);

        /// <summary>
        /// Add a new call to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        ApiResponse<Conversation> PostConversationsCallWithHttpInfo (string conversationId, CallCommand body);
        /// <summary>
        /// Initiate and update consult transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Destination address &amp; initial speak to</param>
        /// <returns>ConsultTransferResponse</returns>
        ConsultTransferResponse PostConversationsCallParticipantConsult (string conversationId, string participantId, ConsultTransfer body);

        /// <summary>
        /// Initiate and update consult transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Destination address &amp; initial speak to</param>
        /// <returns>ApiResponse of ConsultTransferResponse</returns>
        ApiResponse<ConsultTransferResponse> PostConversationsCallParticipantConsultWithHttpInfo (string conversationId, string participantId, ConsultTransfer body);
        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns></returns>
        void PostConversationsCallParticipantMonitor (string conversationId, string participantId);

        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostConversationsCallParticipantMonitorWithHttpInfo (string conversationId, string participantId);
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns></returns>
        void PostConversationsCallParticipantReplace (string conversationId, string participantId, TransferRequest body);

        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostConversationsCallParticipantReplaceWithHttpInfo (string conversationId, string participantId, TransferRequest body);
        /// <summary>
        /// Add participants to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        Conversation PostConversationsCallParticipants (string conversationId, Conversation body);

        /// <summary>
        /// Add participants to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        ApiResponse<Conversation> PostConversationsCallParticipantsWithHttpInfo (string conversationId, Conversation body);
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns></returns>
        void PostConversationsCallbackParticipantReplace (string conversationId, string participantId, TransferRequest body);

        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostConversationsCallbackParticipantReplaceWithHttpInfo (string conversationId, string participantId, TransferRequest body);
        /// <summary>
        /// Create a Callback
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Callback</param>
        /// <returns>CreateCallbackResponse</returns>
        CreateCallbackResponse PostConversationsCallbacks (CreateCallbackCommand body);

        /// <summary>
        /// Create a Callback
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Callback</param>
        /// <returns>ApiResponse of CreateCallbackResponse</returns>
        ApiResponse<CreateCallbackResponse> PostConversationsCallbacksWithHttpInfo (CreateCallbackCommand body);
        /// <summary>
        /// Create a call conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Call request</param>
        /// <returns>CreateCallResponse</returns>
        CreateCallResponse PostConversationsCalls (CreateCallRequest body);

        /// <summary>
        /// Create a call conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Call request</param>
        /// <returns>ApiResponse of CreateCallResponse</returns>
        ApiResponse<CreateCallResponse> PostConversationsCallsWithHttpInfo (CreateCallRequest body);
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns></returns>
        void PostConversationsChatParticipantReplace (string conversationId, string participantId, TransferRequest body);

        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostConversationsChatParticipantReplaceWithHttpInfo (string conversationId, string participantId, TransferRequest body);
        /// <summary>
        /// Create a web chat conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create web chat request</param>
        /// <returns>ChatConversation</returns>
        ChatConversation PostConversationsChats (CreateWebChatRequest body);

        /// <summary>
        /// Create a web chat conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create web chat request</param>
        /// <returns>ApiResponse of ChatConversation</returns>
        ApiResponse<ChatConversation> PostConversationsChatsWithHttpInfo (CreateWebChatRequest body);
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        void PostConversationsCobrowsesessionParticipantReplace (string conversationId, string participantId, TransferRequest body = null);

        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostConversationsCobrowsesessionParticipantReplaceWithHttpInfo (string conversationId, string participantId, TransferRequest body = null);
        /// <summary>
        /// Send an email reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Reply</param>
        /// <returns>EmailMessage</returns>
        EmailMessage PostConversationsEmailMessages (string conversationId, EmailMessage body);

        /// <summary>
        /// Send an email reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Reply</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        ApiResponse<EmailMessage> PostConversationsEmailMessagesWithHttpInfo (string conversationId, EmailMessage body);
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns></returns>
        void PostConversationsEmailParticipantReplace (string conversationId, string participantId, TransferRequest body);

        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostConversationsEmailParticipantReplaceWithHttpInfo (string conversationId, string participantId, TransferRequest body);
        /// <summary>
        /// Create an email conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create email request</param>
        /// <returns>EmailConversation</returns>
        EmailConversation PostConversationsEmails (CreateEmailRequest body);

        /// <summary>
        /// Create an email conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create email request</param>
        /// <returns>ApiResponse of EmailConversation</returns>
        ApiResponse<EmailConversation> PostConversationsEmailsWithHttpInfo (CreateEmailRequest body);
        /// <summary>
        /// Create Fax Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Fax</param>
        /// <returns>FaxSendResponse</returns>
        FaxSendResponse PostConversationsFaxes (FaxSendRequest body);

        /// <summary>
        /// Create Fax Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Fax</param>
        /// <returns>ApiResponse of FaxSendResponse</returns>
        ApiResponse<FaxSendResponse> PostConversationsFaxesWithHttpInfo (FaxSendRequest body);
        /// <summary>
        /// Update conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Draft</param>
        /// <returns>EmailMessage</returns>
        EmailMessage PutConversationsEmailMessagesDraft (string conversationId, EmailMessage body);

        /// <summary>
        /// Update conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Draft</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        ApiResponse<EmailMessage> PutConversationsEmailMessagesDraftWithHttpInfo (string conversationId, EmailMessage body);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Delete a code used to add a communication to this participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="addCommunicationCode">addCommunicationCode</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteConversationParticipantCodeAsync (string conversationId, string participantId, string addCommunicationCode);

        /// <summary>
        /// Delete a code used to add a communication to this participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="addCommunicationCode">addCommunicationCode</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteConversationParticipantCodeAsyncWithHttpInfo (string conversationId, string participantId, string addCommunicationCode);
        /// <summary>
        /// Cancel the transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteConversationsCallParticipantConsultAsync (string conversationId, string participantId);

        /// <summary>
        /// Cancel the transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteConversationsCallParticipantConsultAsyncWithHttpInfo (string conversationId, string participantId);
        /// <summary>
        /// Delete attachment from draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="attachmentId">attachmentId</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteConversationsEmailMessagesDraftAttachmentAsync (string conversationId, string attachmentId);

        /// <summary>
        /// Delete attachment from draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="attachmentId">attachmentId</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteConversationsEmailMessagesDraftAttachmentAsyncWithHttpInfo (string conversationId, string attachmentId);
        /// <summary>
        /// Get a conversation by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of AnalyticsConversation</returns>
        System.Threading.Tasks.Task<AnalyticsConversation> GetAnalyticsConversationDetailsAsync (string conversationId);

        /// <summary>
        /// Get a conversation by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of ApiResponse (AnalyticsConversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<AnalyticsConversation>> GetAnalyticsConversationDetailsAsyncWithHttpInfo (string conversationId);
        /// <summary>
        /// Get conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of Conversation</returns>
        System.Threading.Tasks.Task<Conversation> GetConversationAsync (string conversationId);

        /// <summary>
        /// Get conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Conversation>> GetConversationAsyncWithHttpInfo (string conversationId);
        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of WrapupCode</returns>
        System.Threading.Tasks.Task<WrapupCode> GetConversationParticipantWrapupAsync (string conversationId, string participantId, bool? provisional = null);

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetConversationParticipantWrapupAsyncWithHttpInfo (string conversationId, string participantId, bool? provisional = null);
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>Task of List&lt;WrapupCode&gt;</returns>
        System.Threading.Tasks.Task<List<WrapupCode>> GetConversationParticipantWrapupcodesAsync (string conversationId, string participantId);

        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>Task of ApiResponse (List&lt;WrapupCode&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<WrapupCode>>> GetConversationParticipantWrapupcodesAsyncWithHttpInfo (string conversationId, string participantId);
        /// <summary>
        /// Get conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="communicationType">Call or Chat communication filtering (optional)</param>
        /// <returns>Task of ConversationEntityListing</returns>
        System.Threading.Tasks.Task<ConversationEntityListing> GetConversationsAsync (string communicationType = null);

        /// <summary>
        /// Get conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="communicationType">Call or Chat communication filtering (optional)</param>
        /// <returns>Task of ApiResponse (ConversationEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConversationEntityListing>> GetConversationsAsyncWithHttpInfo (string communicationType = null);
        /// <summary>
        /// Get call conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of CallConversation</returns>
        System.Threading.Tasks.Task<CallConversation> GetConversationsCallAsync (string conversationId);

        /// <summary>
        /// Get call conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of ApiResponse (CallConversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallConversation>> GetConversationsCallAsyncWithHttpInfo (string conversationId);
        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of Wrapup</returns>
        System.Threading.Tasks.Task<Wrapup> GetConversationsCallParticipantWrapupAsync (string conversationId, string participantId, bool? provisional = null);

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (Wrapup)</returns>
        System.Threading.Tasks.Task<ApiResponse<Wrapup>> GetConversationsCallParticipantWrapupAsyncWithHttpInfo (string conversationId, string participantId, bool? provisional = null);
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of List&lt;WrapupCode&gt;</returns>
        System.Threading.Tasks.Task<List<WrapupCode>> GetConversationsCallParticipantWrapupcodesAsync (string conversationId, string participantId);

        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of ApiResponse (List&lt;WrapupCode&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<WrapupCode>>> GetConversationsCallParticipantWrapupcodesAsyncWithHttpInfo (string conversationId, string participantId);
        /// <summary>
        /// Get callback conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of CallbackConversation</returns>
        System.Threading.Tasks.Task<CallbackConversation> GetConversationsCallbackAsync (string conversationId);

        /// <summary>
        /// Get callback conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of ApiResponse (CallbackConversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallbackConversation>> GetConversationsCallbackAsyncWithHttpInfo (string conversationId);
        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of Wrapup</returns>
        System.Threading.Tasks.Task<Wrapup> GetConversationsCallbackParticipantWrapupAsync (string conversationId, string participantId, bool? provisional = null);

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (Wrapup)</returns>
        System.Threading.Tasks.Task<ApiResponse<Wrapup>> GetConversationsCallbackParticipantWrapupAsyncWithHttpInfo (string conversationId, string participantId, bool? provisional = null);
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of List&lt;WrapupCode&gt;</returns>
        System.Threading.Tasks.Task<List<WrapupCode>> GetConversationsCallbackParticipantWrapupcodesAsync (string conversationId, string participantId);

        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of ApiResponse (List&lt;WrapupCode&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<WrapupCode>>> GetConversationsCallbackParticipantWrapupcodesAsyncWithHttpInfo (string conversationId, string participantId);
        /// <summary>
        /// Get callback conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of CallbackConversationEntityListing</returns>
        System.Threading.Tasks.Task<CallbackConversationEntityListing> GetConversationsCallbacksAsync ();

        /// <summary>
        /// Get callback conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (CallbackConversationEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallbackConversationEntityListing>> GetConversationsCallbacksAsyncWithHttpInfo ();
        /// <summary>
        /// Get recent conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of CallConversationEntityListing</returns>
        System.Threading.Tasks.Task<CallConversationEntityListing> GetConversationsCallsAsync ();

        /// <summary>
        /// Get recent conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (CallConversationEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallConversationEntityListing>> GetConversationsCallsAsyncWithHttpInfo ();
        /// <summary>
        /// Get call history
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="interval">Interval string; format is ISO-8601. Separate start and end times with forward slash &#39;/&#39; (optional)</param>
        /// <returns>Task of CallConversationEntityListing</returns>
        System.Threading.Tasks.Task<CallConversationEntityListing> GetConversationsCallsHistoryAsync (int? pageSize = null, int? pageNumber = null, string interval = null);

        /// <summary>
        /// Get call history
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="interval">Interval string; format is ISO-8601. Separate start and end times with forward slash &#39;/&#39; (optional)</param>
        /// <returns>Task of ApiResponse (CallConversationEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallConversationEntityListing>> GetConversationsCallsHistoryAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string interval = null);
        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of MaxParticipants</returns>
        System.Threading.Tasks.Task<MaxParticipants> GetConversationsCallsMaximumconferencepartiesAsync ();

        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (MaxParticipants)</returns>
        System.Threading.Tasks.Task<ApiResponse<MaxParticipants>> GetConversationsCallsMaximumconferencepartiesAsyncWithHttpInfo ();
        /// <summary>
        /// Get chat conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of ChatConversation</returns>
        System.Threading.Tasks.Task<ChatConversation> GetConversationsChatAsync (string conversationId);

        /// <summary>
        /// Get chat conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of ApiResponse (ChatConversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<ChatConversation>> GetConversationsChatAsyncWithHttpInfo (string conversationId);
        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of Wrapup</returns>
        System.Threading.Tasks.Task<Wrapup> GetConversationsChatParticipantWrapupAsync (string conversationId, string participantId, bool? provisional = null);

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (Wrapup)</returns>
        System.Threading.Tasks.Task<ApiResponse<Wrapup>> GetConversationsChatParticipantWrapupAsyncWithHttpInfo (string conversationId, string participantId, bool? provisional = null);
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of List&lt;WrapupCode&gt;</returns>
        System.Threading.Tasks.Task<List<WrapupCode>> GetConversationsChatParticipantWrapupcodesAsync (string conversationId, string participantId);

        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of ApiResponse (List&lt;WrapupCode&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<WrapupCode>>> GetConversationsChatParticipantWrapupcodesAsyncWithHttpInfo (string conversationId, string participantId);
        /// <summary>
        /// Get recent chat conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ChatConversationEntityListing</returns>
        System.Threading.Tasks.Task<ChatConversationEntityListing> GetConversationsChatsAsync ();

        /// <summary>
        /// Get recent chat conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ChatConversationEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ChatConversationEntityListing>> GetConversationsChatsAsyncWithHttpInfo ();
        /// <summary>
        /// Get cobrowse conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of CobrowseConversation</returns>
        System.Threading.Tasks.Task<CobrowseConversation> GetConversationsCobrowsesessionAsync (string conversationId);

        /// <summary>
        /// Get cobrowse conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of ApiResponse (CobrowseConversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<CobrowseConversation>> GetConversationsCobrowsesessionAsyncWithHttpInfo (string conversationId);
        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of Wrapup</returns>
        System.Threading.Tasks.Task<Wrapup> GetConversationsCobrowsesessionParticipantWrapupAsync (string conversationId, string participantId, bool? provisional = null);

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (Wrapup)</returns>
        System.Threading.Tasks.Task<ApiResponse<Wrapup>> GetConversationsCobrowsesessionParticipantWrapupAsyncWithHttpInfo (string conversationId, string participantId, bool? provisional = null);
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of List&lt;WrapupCode&gt;</returns>
        System.Threading.Tasks.Task<List<WrapupCode>> GetConversationsCobrowsesessionParticipantWrapupcodesAsync (string conversationId, string participantId);

        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of ApiResponse (List&lt;WrapupCode&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<WrapupCode>>> GetConversationsCobrowsesessionParticipantWrapupcodesAsyncWithHttpInfo (string conversationId, string participantId);
        /// <summary>
        /// Get recent cobrowse conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of CobrowseConversationEntityListing</returns>
        System.Threading.Tasks.Task<CobrowseConversationEntityListing> GetConversationsCobrowsesessionsAsync ();

        /// <summary>
        /// Get recent cobrowse conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (CobrowseConversationEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<CobrowseConversationEntityListing>> GetConversationsCobrowsesessionsAsyncWithHttpInfo ();
        /// <summary>
        /// Get email conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of EmailConversation</returns>
        System.Threading.Tasks.Task<EmailConversation> GetConversationsEmailAsync (string conversationId);

        /// <summary>
        /// Get email conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of ApiResponse (EmailConversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailConversation>> GetConversationsEmailAsyncWithHttpInfo (string conversationId);
        /// <summary>
        /// Get conversation message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>Task of EmailMessage</returns>
        System.Threading.Tasks.Task<EmailMessage> GetConversationsEmailMessageAsync (string conversationId, string messageId);

        /// <summary>
        /// Get conversation message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailMessage>> GetConversationsEmailMessageAsyncWithHttpInfo (string conversationId, string messageId);
        /// <summary>
        /// Get conversation messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of EmailMessageListing</returns>
        System.Threading.Tasks.Task<EmailMessageListing> GetConversationsEmailMessagesAsync (string conversationId);

        /// <summary>
        /// Get conversation messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of ApiResponse (EmailMessageListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailMessageListing>> GetConversationsEmailMessagesAsyncWithHttpInfo (string conversationId);
        /// <summary>
        /// Get conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of EmailMessage</returns>
        System.Threading.Tasks.Task<EmailMessage> GetConversationsEmailMessagesDraftAsync (string conversationId);

        /// <summary>
        /// Get conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailMessage>> GetConversationsEmailMessagesDraftAsyncWithHttpInfo (string conversationId);
        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of Wrapup</returns>
        System.Threading.Tasks.Task<Wrapup> GetConversationsEmailParticipantWrapupAsync (string conversationId, string participantId, bool? provisional = null);

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (Wrapup)</returns>
        System.Threading.Tasks.Task<ApiResponse<Wrapup>> GetConversationsEmailParticipantWrapupAsyncWithHttpInfo (string conversationId, string participantId, bool? provisional = null);
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of List&lt;WrapupCode&gt;</returns>
        System.Threading.Tasks.Task<List<WrapupCode>> GetConversationsEmailParticipantWrapupcodesAsync (string conversationId, string participantId);

        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of ApiResponse (List&lt;WrapupCode&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<WrapupCode>>> GetConversationsEmailParticipantWrapupcodesAsyncWithHttpInfo (string conversationId, string participantId);
        /// <summary>
        /// Get recent email conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of EmailConversationEntityListing</returns>
        System.Threading.Tasks.Task<EmailConversationEntityListing> GetConversationsEmailsAsync ();

        /// <summary>
        /// Get recent email conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (EmailConversationEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailConversationEntityListing>> GetConversationsEmailsAsyncWithHttpInfo ();
        /// <summary>
        /// Update a participant.
        /// </summary>
        /// <remarks>
        /// Update conversation participant.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Update request</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchConversationParticipantAsync (string conversationId, string participantId, MediaParticipantRequest body);

        /// <summary>
        /// Update a participant.
        /// </summary>
        /// <remarks>
        /// Update conversation participant.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Update request</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchConversationParticipantAsyncWithHttpInfo (string conversationId, string participantId, MediaParticipantRequest body);
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchConversationParticipantAttributesAsync (string conversationId, string participantId, ParticipantAttributes body);

        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchConversationParticipantAttributesAsyncWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body);
        /// <summary>
        /// Update a conversation by setting it&#39;s recording state, merging in other conversations to create a conference, or disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        System.Threading.Tasks.Task<Conversation> PatchConversationsCallAsync (string conversationId, Conversation body);

        /// <summary>
        /// Update a conversation by setting it&#39;s recording state, merging in other conversations to create a conference, or disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Conversation>> PatchConversationsCallAsyncWithHttpInfo (string conversationId, Conversation body);
        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant request</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchConversationsCallParticipantAsync (string conversationId, string participantId, MediaParticipantRequest body);

        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant request</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchConversationsCallParticipantAsyncWithHttpInfo (string conversationId, string participantId, MediaParticipantRequest body);
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchConversationsCallParticipantAttributesAsync (string conversationId, string participantId, ParticipantAttributes body);

        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchConversationsCallParticipantAttributesAsyncWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body);
        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of Empty</returns>
        System.Threading.Tasks.Task<Empty> PatchConversationsCallParticipantCommunicationAsync (string conversationId, string participantId, string communicationId, MediaParticipantRequest body);

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of ApiResponse (Empty)</returns>
        System.Threading.Tasks.Task<ApiResponse<Empty>> PatchConversationsCallParticipantCommunicationAsyncWithHttpInfo (string conversationId, string participantId, string communicationId, MediaParticipantRequest body);
        /// <summary>
        /// Change who can speak
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">new speak to</param>
        /// <returns>Task of ConsultTransferResponse</returns>
        System.Threading.Tasks.Task<ConsultTransferResponse> PatchConversationsCallParticipantConsultAsync (string conversationId, string participantId, ConsultTransferUpdate body);

        /// <summary>
        /// Change who can speak
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">new speak to</param>
        /// <returns>Task of ApiResponse (ConsultTransferResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConsultTransferResponse>> PatchConversationsCallParticipantConsultAsyncWithHttpInfo (string conversationId, string participantId, ConsultTransferUpdate body);
        /// <summary>
        /// Update a conversation by disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        System.Threading.Tasks.Task<Conversation> PatchConversationsCallbackAsync (string conversationId, Conversation body);

        /// <summary>
        /// Update a conversation by disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Conversation>> PatchConversationsCallbackAsyncWithHttpInfo (string conversationId, Conversation body);
        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchConversationsCallbackParticipantAsync (string conversationId, string participantId, MediaParticipantRequest body);

        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchConversationsCallbackParticipantAsyncWithHttpInfo (string conversationId, string participantId, MediaParticipantRequest body);
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Attributes</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchConversationsCallbackParticipantAttributesAsync (string conversationId, string participantId, ParticipantAttributes body);

        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Attributes</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchConversationsCallbackParticipantAttributesAsyncWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body);
        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of Empty</returns>
        System.Threading.Tasks.Task<Empty> PatchConversationsCallbackParticipantCommunicationAsync (string conversationId, string participantId, string communicationId, MediaParticipantRequest body);

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of ApiResponse (Empty)</returns>
        System.Threading.Tasks.Task<ApiResponse<Empty>> PatchConversationsCallbackParticipantCommunicationAsyncWithHttpInfo (string conversationId, string participantId, string communicationId, MediaParticipantRequest body);
        /// <summary>
        /// Update a conversation by disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        System.Threading.Tasks.Task<Conversation> PatchConversationsChatAsync (string conversationId, Conversation body);

        /// <summary>
        /// Update a conversation by disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Conversation>> PatchConversationsChatAsyncWithHttpInfo (string conversationId, Conversation body);
        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Update request</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchConversationsChatParticipantAsync (string conversationId, string participantId, MediaParticipantRequest body);

        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Update request</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchConversationsChatParticipantAsyncWithHttpInfo (string conversationId, string participantId, MediaParticipantRequest body);
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchConversationsChatParticipantAttributesAsync (string conversationId, string participantId, ParticipantAttributes body);

        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchConversationsChatParticipantAttributesAsyncWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body);
        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of Empty</returns>
        System.Threading.Tasks.Task<Empty> PatchConversationsChatParticipantCommunicationAsync (string conversationId, string participantId, string communicationId, MediaParticipantRequest body);

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of ApiResponse (Empty)</returns>
        System.Threading.Tasks.Task<ApiResponse<Empty>> PatchConversationsChatParticipantCommunicationAsyncWithHttpInfo (string conversationId, string participantId, string communicationId, MediaParticipantRequest body);
        /// <summary>
        /// Update a conversation by disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        System.Threading.Tasks.Task<Conversation> PatchConversationsCobrowsesessionAsync (string conversationId, Conversation body);

        /// <summary>
        /// Update a conversation by disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Conversation>> PatchConversationsCobrowsesessionAsyncWithHttpInfo (string conversationId, Conversation body);
        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchConversationsCobrowsesessionParticipantAsync (string conversationId, string participantId, MediaParticipantRequest body = null);

        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchConversationsCobrowsesessionParticipantAsyncWithHttpInfo (string conversationId, string participantId, MediaParticipantRequest body = null);
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchConversationsCobrowsesessionParticipantAttributesAsync (string conversationId, string participantId, ParticipantAttributes body = null);

        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchConversationsCobrowsesessionParticipantAttributesAsyncWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body = null);
        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of Empty</returns>
        System.Threading.Tasks.Task<Empty> PatchConversationsCobrowsesessionParticipantCommunicationAsync (string conversationId, string participantId, string communicationId, MediaParticipantRequest body);

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of ApiResponse (Empty)</returns>
        System.Threading.Tasks.Task<ApiResponse<Empty>> PatchConversationsCobrowsesessionParticipantCommunicationAsyncWithHttpInfo (string conversationId, string participantId, string communicationId, MediaParticipantRequest body);
        /// <summary>
        /// Update a conversation by disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        System.Threading.Tasks.Task<Conversation> PatchConversationsEmailAsync (string conversationId, Conversation body);

        /// <summary>
        /// Update a conversation by disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Conversation>> PatchConversationsEmailAsyncWithHttpInfo (string conversationId, Conversation body);
        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Update request</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchConversationsEmailParticipantAsync (string conversationId, string participantId, MediaParticipantRequest body);

        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Update request</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchConversationsEmailParticipantAsyncWithHttpInfo (string conversationId, string participantId, MediaParticipantRequest body);
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchConversationsEmailParticipantAttributesAsync (string conversationId, string participantId, ParticipantAttributes body);

        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchConversationsEmailParticipantAttributesAsyncWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body);
        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of Empty</returns>
        System.Threading.Tasks.Task<Empty> PatchConversationsEmailParticipantCommunicationAsync (string conversationId, string participantId, string communicationId, MediaParticipantRequest body);

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of ApiResponse (Empty)</returns>
        System.Threading.Tasks.Task<ApiResponse<Empty>> PatchConversationsEmailParticipantCommunicationAsyncWithHttpInfo (string conversationId, string participantId, string communicationId, MediaParticipantRequest body);
        /// <summary>
        /// Index conversation properties
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">request</param>
        /// <returns>Task of PropertyIndexRequest</returns>
        System.Threading.Tasks.Task<PropertyIndexRequest> PostAnalyticsConversationDetailsPropertiesAsync (string conversationId, PropertyIndexRequest body);

        /// <summary>
        /// Index conversation properties
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">request</param>
        /// <returns>Task of ApiResponse (PropertyIndexRequest)</returns>
        System.Threading.Tasks.Task<ApiResponse<PropertyIndexRequest>> PostAnalyticsConversationDetailsPropertiesAsyncWithHttpInfo (string conversationId, PropertyIndexRequest body);
        /// <summary>
        /// Query for conversation aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of AggregateQueryResponse</returns>
        System.Threading.Tasks.Task<AggregateQueryResponse> PostAnalyticsConversationsAggregatesQueryAsync (AggregationQuery body);

        /// <summary>
        /// Query for conversation aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (AggregateQueryResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AggregateQueryResponse>> PostAnalyticsConversationsAggregatesQueryAsyncWithHttpInfo (AggregationQuery body);
        /// <summary>
        /// Query for conversation details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of AnalyticsConversationQueryResponse</returns>
        System.Threading.Tasks.Task<AnalyticsConversationQueryResponse> PostAnalyticsConversationsDetailsQueryAsync (ConversationQuery body);

        /// <summary>
        /// Query for conversation details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (AnalyticsConversationQueryResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AnalyticsConversationQueryResponse>> PostAnalyticsConversationsDetailsQueryAsyncWithHttpInfo (ConversationQuery body);
        /// <summary>
        /// Create a new callback for the specified participant on the conversation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostConversationParticipantCallbacksAsync (string conversationId, string participantId, CreateCallbackCommand body = null);

        /// <summary>
        /// Create a new callback for the specified participant on the conversation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostConversationParticipantCallbacksAsyncWithHttpInfo (string conversationId, string participantId, CreateCallbackCommand body = null);
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostConversationParticipantReplaceAsync (string conversationId, string participantId, TransferRequest body);

        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostConversationParticipantReplaceAsyncWithHttpInfo (string conversationId, string participantId, TransferRequest body);
        /// <summary>
        /// Add a new call to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        System.Threading.Tasks.Task<Conversation> PostConversationsCallAsync (string conversationId, CallCommand body);

        /// <summary>
        /// Add a new call to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Conversation>> PostConversationsCallAsyncWithHttpInfo (string conversationId, CallCommand body);
        /// <summary>
        /// Initiate and update consult transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Destination address &amp; initial speak to</param>
        /// <returns>Task of ConsultTransferResponse</returns>
        System.Threading.Tasks.Task<ConsultTransferResponse> PostConversationsCallParticipantConsultAsync (string conversationId, string participantId, ConsultTransfer body);

        /// <summary>
        /// Initiate and update consult transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Destination address &amp; initial speak to</param>
        /// <returns>Task of ApiResponse (ConsultTransferResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConsultTransferResponse>> PostConversationsCallParticipantConsultAsyncWithHttpInfo (string conversationId, string participantId, ConsultTransfer body);
        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostConversationsCallParticipantMonitorAsync (string conversationId, string participantId);

        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostConversationsCallParticipantMonitorAsyncWithHttpInfo (string conversationId, string participantId);
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostConversationsCallParticipantReplaceAsync (string conversationId, string participantId, TransferRequest body);

        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostConversationsCallParticipantReplaceAsyncWithHttpInfo (string conversationId, string participantId, TransferRequest body);
        /// <summary>
        /// Add participants to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        System.Threading.Tasks.Task<Conversation> PostConversationsCallParticipantsAsync (string conversationId, Conversation body);

        /// <summary>
        /// Add participants to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Conversation>> PostConversationsCallParticipantsAsyncWithHttpInfo (string conversationId, Conversation body);
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostConversationsCallbackParticipantReplaceAsync (string conversationId, string participantId, TransferRequest body);

        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostConversationsCallbackParticipantReplaceAsyncWithHttpInfo (string conversationId, string participantId, TransferRequest body);
        /// <summary>
        /// Create a Callback
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Callback</param>
        /// <returns>Task of CreateCallbackResponse</returns>
        System.Threading.Tasks.Task<CreateCallbackResponse> PostConversationsCallbacksAsync (CreateCallbackCommand body);

        /// <summary>
        /// Create a Callback
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Callback</param>
        /// <returns>Task of ApiResponse (CreateCallbackResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateCallbackResponse>> PostConversationsCallbacksAsyncWithHttpInfo (CreateCallbackCommand body);
        /// <summary>
        /// Create a call conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Call request</param>
        /// <returns>Task of CreateCallResponse</returns>
        System.Threading.Tasks.Task<CreateCallResponse> PostConversationsCallsAsync (CreateCallRequest body);

        /// <summary>
        /// Create a call conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Call request</param>
        /// <returns>Task of ApiResponse (CreateCallResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateCallResponse>> PostConversationsCallsAsyncWithHttpInfo (CreateCallRequest body);
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostConversationsChatParticipantReplaceAsync (string conversationId, string participantId, TransferRequest body);

        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostConversationsChatParticipantReplaceAsyncWithHttpInfo (string conversationId, string participantId, TransferRequest body);
        /// <summary>
        /// Create a web chat conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create web chat request</param>
        /// <returns>Task of ChatConversation</returns>
        System.Threading.Tasks.Task<ChatConversation> PostConversationsChatsAsync (CreateWebChatRequest body);

        /// <summary>
        /// Create a web chat conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create web chat request</param>
        /// <returns>Task of ApiResponse (ChatConversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<ChatConversation>> PostConversationsChatsAsyncWithHttpInfo (CreateWebChatRequest body);
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostConversationsCobrowsesessionParticipantReplaceAsync (string conversationId, string participantId, TransferRequest body = null);

        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostConversationsCobrowsesessionParticipantReplaceAsyncWithHttpInfo (string conversationId, string participantId, TransferRequest body = null);
        /// <summary>
        /// Send an email reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Reply</param>
        /// <returns>Task of EmailMessage</returns>
        System.Threading.Tasks.Task<EmailMessage> PostConversationsEmailMessagesAsync (string conversationId, EmailMessage body);

        /// <summary>
        /// Send an email reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Reply</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailMessage>> PostConversationsEmailMessagesAsyncWithHttpInfo (string conversationId, EmailMessage body);
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostConversationsEmailParticipantReplaceAsync (string conversationId, string participantId, TransferRequest body);

        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostConversationsEmailParticipantReplaceAsyncWithHttpInfo (string conversationId, string participantId, TransferRequest body);
        /// <summary>
        /// Create an email conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create email request</param>
        /// <returns>Task of EmailConversation</returns>
        System.Threading.Tasks.Task<EmailConversation> PostConversationsEmailsAsync (CreateEmailRequest body);

        /// <summary>
        /// Create an email conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create email request</param>
        /// <returns>Task of ApiResponse (EmailConversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailConversation>> PostConversationsEmailsAsyncWithHttpInfo (CreateEmailRequest body);
        /// <summary>
        /// Create Fax Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Fax</param>
        /// <returns>Task of FaxSendResponse</returns>
        System.Threading.Tasks.Task<FaxSendResponse> PostConversationsFaxesAsync (FaxSendRequest body);

        /// <summary>
        /// Create Fax Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Fax</param>
        /// <returns>Task of ApiResponse (FaxSendResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<FaxSendResponse>> PostConversationsFaxesAsyncWithHttpInfo (FaxSendRequest body);
        /// <summary>
        /// Update conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Draft</param>
        /// <returns>Task of EmailMessage</returns>
        System.Threading.Tasks.Task<EmailMessage> PutConversationsEmailMessagesDraftAsync (string conversationId, EmailMessage body);

        /// <summary>
        /// Update conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Draft</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailMessage>> PutConversationsEmailMessagesDraftAsyncWithHttpInfo (string conversationId, EmailMessage body);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ConversationsApi : IConversationsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConversationsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ConversationsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Delete a code used to add a communication to this participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="addCommunicationCode">addCommunicationCode</param>
        /// <returns></returns>
        public void DeleteConversationParticipantCode (string conversationId, string participantId, string addCommunicationCode)
        {
             DeleteConversationParticipantCodeWithHttpInfo(conversationId, participantId, addCommunicationCode);
        }

        /// <summary>
        /// Delete a code used to add a communication to this participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="addCommunicationCode">addCommunicationCode</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteConversationParticipantCodeWithHttpInfo (string conversationId, string participantId, string addCommunicationCode)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->DeleteConversationParticipantCode");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->DeleteConversationParticipantCode");
            // verify the required parameter 'addCommunicationCode' is set
            if (addCommunicationCode == null)
                throw new ApiException(400, "Missing required parameter 'addCommunicationCode' when calling ConversationsApi->DeleteConversationParticipantCode");

            var localVarPath = "/api/v2/conversations/{conversationId}/participants/{participantId}/codes/{addCommunicationCode}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (addCommunicationCode != null) localVarPathParams.Add("addCommunicationCode", Configuration.ApiClient.ParameterToString(addCommunicationCode)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteConversationParticipantCode: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteConversationParticipantCode: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Delete a code used to add a communication to this participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="addCommunicationCode">addCommunicationCode</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteConversationParticipantCodeAsync (string conversationId, string participantId, string addCommunicationCode)
        {
             await DeleteConversationParticipantCodeAsyncWithHttpInfo(conversationId, participantId, addCommunicationCode);

        }

        /// <summary>
        /// Delete a code used to add a communication to this participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="addCommunicationCode">addCommunicationCode</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteConversationParticipantCodeAsyncWithHttpInfo (string conversationId, string participantId, string addCommunicationCode)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->DeleteConversationParticipantCode");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->DeleteConversationParticipantCode");
            // verify the required parameter 'addCommunicationCode' is set
            if (addCommunicationCode == null)
                throw new ApiException(400, "Missing required parameter 'addCommunicationCode' when calling ConversationsApi->DeleteConversationParticipantCode");

            var localVarPath = "/api/v2/conversations/{conversationId}/participants/{participantId}/codes/{addCommunicationCode}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (addCommunicationCode != null) localVarPathParams.Add("addCommunicationCode", Configuration.ApiClient.ParameterToString(addCommunicationCode)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteConversationParticipantCode: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteConversationParticipantCode: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Cancel the transfer 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>string</returns>
        public string DeleteConversationsCallParticipantConsult (string conversationId, string participantId)
        {
             ApiResponse<string> localVarResponse = DeleteConversationsCallParticipantConsultWithHttpInfo(conversationId, participantId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cancel the transfer 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteConversationsCallParticipantConsultWithHttpInfo (string conversationId, string participantId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->DeleteConversationsCallParticipantConsult");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->DeleteConversationsCallParticipantConsult");

            var localVarPath = "/api/v2/conversations/calls/{conversationId}/participants/{participantId}/consult";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteConversationsCallParticipantConsult: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteConversationsCallParticipantConsult: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarHeaders,
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Cancel the transfer 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteConversationsCallParticipantConsultAsync (string conversationId, string participantId)
        {
             ApiResponse<string> localVarResponse = await DeleteConversationsCallParticipantConsultAsyncWithHttpInfo(conversationId, participantId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cancel the transfer 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteConversationsCallParticipantConsultAsyncWithHttpInfo (string conversationId, string participantId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->DeleteConversationsCallParticipantConsult");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->DeleteConversationsCallParticipantConsult");

            var localVarPath = "/api/v2/conversations/calls/{conversationId}/participants/{participantId}/consult";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteConversationsCallParticipantConsult: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteConversationsCallParticipantConsult: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarHeaders,
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete attachment from draft 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="attachmentId">attachmentId</param>
        /// <returns>string</returns>
        public string DeleteConversationsEmailMessagesDraftAttachment (string conversationId, string attachmentId)
        {
             ApiResponse<string> localVarResponse = DeleteConversationsEmailMessagesDraftAttachmentWithHttpInfo(conversationId, attachmentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete attachment from draft 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="attachmentId">attachmentId</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteConversationsEmailMessagesDraftAttachmentWithHttpInfo (string conversationId, string attachmentId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->DeleteConversationsEmailMessagesDraftAttachment");
            // verify the required parameter 'attachmentId' is set
            if (attachmentId == null)
                throw new ApiException(400, "Missing required parameter 'attachmentId' when calling ConversationsApi->DeleteConversationsEmailMessagesDraftAttachment");

            var localVarPath = "/api/v2/conversations/emails/{conversationId}/messages/draft/attachments/{attachmentId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (attachmentId != null) localVarPathParams.Add("attachmentId", Configuration.ApiClient.ParameterToString(attachmentId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteConversationsEmailMessagesDraftAttachment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteConversationsEmailMessagesDraftAttachment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarHeaders,
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete attachment from draft 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="attachmentId">attachmentId</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteConversationsEmailMessagesDraftAttachmentAsync (string conversationId, string attachmentId)
        {
             ApiResponse<string> localVarResponse = await DeleteConversationsEmailMessagesDraftAttachmentAsyncWithHttpInfo(conversationId, attachmentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete attachment from draft 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="attachmentId">attachmentId</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteConversationsEmailMessagesDraftAttachmentAsyncWithHttpInfo (string conversationId, string attachmentId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->DeleteConversationsEmailMessagesDraftAttachment");
            // verify the required parameter 'attachmentId' is set
            if (attachmentId == null)
                throw new ApiException(400, "Missing required parameter 'attachmentId' when calling ConversationsApi->DeleteConversationsEmailMessagesDraftAttachment");

            var localVarPath = "/api/v2/conversations/emails/{conversationId}/messages/draft/attachments/{attachmentId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (attachmentId != null) localVarPathParams.Add("attachmentId", Configuration.ApiClient.ParameterToString(attachmentId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteConversationsEmailMessagesDraftAttachment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteConversationsEmailMessagesDraftAttachment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarHeaders,
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get a conversation by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>AnalyticsConversation</returns>
        public AnalyticsConversation GetAnalyticsConversationDetails (string conversationId)
        {
             ApiResponse<AnalyticsConversation> localVarResponse = GetAnalyticsConversationDetailsWithHttpInfo(conversationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a conversation by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>ApiResponse of AnalyticsConversation</returns>
        public ApiResponse< AnalyticsConversation > GetAnalyticsConversationDetailsWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetAnalyticsConversationDetails");

            var localVarPath = "/api/v2/analytics/conversations/{conversationId}/details";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAnalyticsConversationDetails: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAnalyticsConversationDetails: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AnalyticsConversation>(localVarStatusCode,
                localVarHeaders,
                (AnalyticsConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AnalyticsConversation)));
            
        }

        /// <summary>
        /// Get a conversation by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of AnalyticsConversation</returns>
        public async System.Threading.Tasks.Task<AnalyticsConversation> GetAnalyticsConversationDetailsAsync (string conversationId)
        {
             ApiResponse<AnalyticsConversation> localVarResponse = await GetAnalyticsConversationDetailsAsyncWithHttpInfo(conversationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a conversation by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of ApiResponse (AnalyticsConversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AnalyticsConversation>> GetAnalyticsConversationDetailsAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetAnalyticsConversationDetails");

            var localVarPath = "/api/v2/analytics/conversations/{conversationId}/details";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAnalyticsConversationDetails: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAnalyticsConversationDetails: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AnalyticsConversation>(localVarStatusCode,
                localVarHeaders,
                (AnalyticsConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AnalyticsConversation)));
            
        }

        /// <summary>
        /// Get conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Conversation</returns>
        public Conversation GetConversation (string conversationId)
        {
             ApiResponse<Conversation> localVarResponse = GetConversationWithHttpInfo(conversationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>ApiResponse of Conversation</returns>
        public ApiResponse< Conversation > GetConversationWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversation");

            var localVarPath = "/api/v2/conversations/{conversationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarHeaders,
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Get conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of Conversation</returns>
        public async System.Threading.Tasks.Task<Conversation> GetConversationAsync (string conversationId)
        {
             ApiResponse<Conversation> localVarResponse = await GetConversationAsyncWithHttpInfo(conversationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conversation>> GetConversationAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversation");

            var localVarPath = "/api/v2/conversations/{conversationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarHeaders,
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>WrapupCode</returns>
        public WrapupCode GetConversationParticipantWrapup (string conversationId, string participantId, bool? provisional = null)
        {
             ApiResponse<WrapupCode> localVarResponse = GetConversationParticipantWrapupWithHttpInfo(conversationId, participantId, provisional);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        public ApiResponse< WrapupCode > GetConversationParticipantWrapupWithHttpInfo (string conversationId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationParticipantWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetConversationParticipantWrapup");

            var localVarPath = "/api/v2/conversations/{conversationId}/participants/{participantId}/wrapup";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (provisional != null) localVarQueryParams.Add("provisional", Configuration.ApiClient.ParameterToString(provisional)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationParticipantWrapup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationParticipantWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarHeaders,
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of WrapupCode</returns>
        public async System.Threading.Tasks.Task<WrapupCode> GetConversationParticipantWrapupAsync (string conversationId, string participantId, bool? provisional = null)
        {
             ApiResponse<WrapupCode> localVarResponse = await GetConversationParticipantWrapupAsyncWithHttpInfo(conversationId, participantId, provisional);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetConversationParticipantWrapupAsyncWithHttpInfo (string conversationId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationParticipantWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetConversationParticipantWrapup");

            var localVarPath = "/api/v2/conversations/{conversationId}/participants/{participantId}/wrapup";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (provisional != null) localVarQueryParams.Add("provisional", Configuration.ApiClient.ParameterToString(provisional)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationParticipantWrapup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationParticipantWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarHeaders,
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>List&lt;WrapupCode&gt;</returns>
        public List<WrapupCode> GetConversationParticipantWrapupcodes (string conversationId, string participantId)
        {
             ApiResponse<List<WrapupCode>> localVarResponse = GetConversationParticipantWrapupcodesWithHttpInfo(conversationId, participantId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>ApiResponse of List&lt;WrapupCode&gt;</returns>
        public ApiResponse< List<WrapupCode> > GetConversationParticipantWrapupcodesWithHttpInfo (string conversationId, string participantId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationParticipantWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetConversationParticipantWrapupcodes");

            var localVarPath = "/api/v2/conversations/{conversationId}/participants/{participantId}/wrapupcodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationParticipantWrapupcodes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationParticipantWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WrapupCode>>(localVarStatusCode,
                localVarHeaders,
                (List<WrapupCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WrapupCode>)));
            
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>Task of List&lt;WrapupCode&gt;</returns>
        public async System.Threading.Tasks.Task<List<WrapupCode>> GetConversationParticipantWrapupcodesAsync (string conversationId, string participantId)
        {
             ApiResponse<List<WrapupCode>> localVarResponse = await GetConversationParticipantWrapupcodesAsyncWithHttpInfo(conversationId, participantId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>Task of ApiResponse (List&lt;WrapupCode&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<WrapupCode>>> GetConversationParticipantWrapupcodesAsyncWithHttpInfo (string conversationId, string participantId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationParticipantWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetConversationParticipantWrapupcodes");

            var localVarPath = "/api/v2/conversations/{conversationId}/participants/{participantId}/wrapupcodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationParticipantWrapupcodes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationParticipantWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WrapupCode>>(localVarStatusCode,
                localVarHeaders,
                (List<WrapupCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WrapupCode>)));
            
        }

        /// <summary>
        /// Get conversations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="communicationType">Call or Chat communication filtering (optional)</param>
        /// <returns>ConversationEntityListing</returns>
        public ConversationEntityListing GetConversations (string communicationType = null)
        {
             ApiResponse<ConversationEntityListing> localVarResponse = GetConversationsWithHttpInfo(communicationType);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get conversations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="communicationType">Call or Chat communication filtering (optional)</param>
        /// <returns>ApiResponse of ConversationEntityListing</returns>
        public ApiResponse< ConversationEntityListing > GetConversationsWithHttpInfo (string communicationType = null)
        {

            var localVarPath = "/api/v2/conversations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (communicationType != null) localVarQueryParams.Add("communicationType", Configuration.ApiClient.ParameterToString(communicationType)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConversationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ConversationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConversationEntityListing)));
            
        }

        /// <summary>
        /// Get conversations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="communicationType">Call or Chat communication filtering (optional)</param>
        /// <returns>Task of ConversationEntityListing</returns>
        public async System.Threading.Tasks.Task<ConversationEntityListing> GetConversationsAsync (string communicationType = null)
        {
             ApiResponse<ConversationEntityListing> localVarResponse = await GetConversationsAsyncWithHttpInfo(communicationType);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get conversations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="communicationType">Call or Chat communication filtering (optional)</param>
        /// <returns>Task of ApiResponse (ConversationEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConversationEntityListing>> GetConversationsAsyncWithHttpInfo (string communicationType = null)
        {

            var localVarPath = "/api/v2/conversations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (communicationType != null) localVarQueryParams.Add("communicationType", Configuration.ApiClient.ParameterToString(communicationType)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConversationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ConversationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConversationEntityListing)));
            
        }

        /// <summary>
        /// Get call conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>CallConversation</returns>
        public CallConversation GetConversationsCall (string conversationId)
        {
             ApiResponse<CallConversation> localVarResponse = GetConversationsCallWithHttpInfo(conversationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get call conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>ApiResponse of CallConversation</returns>
        public ApiResponse< CallConversation > GetConversationsCallWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationsCall");

            var localVarPath = "/api/v2/conversations/calls/{conversationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCall: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCall: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallConversation>(localVarStatusCode,
                localVarHeaders,
                (CallConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallConversation)));
            
        }

        /// <summary>
        /// Get call conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of CallConversation</returns>
        public async System.Threading.Tasks.Task<CallConversation> GetConversationsCallAsync (string conversationId)
        {
             ApiResponse<CallConversation> localVarResponse = await GetConversationsCallAsyncWithHttpInfo(conversationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get call conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of ApiResponse (CallConversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallConversation>> GetConversationsCallAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationsCall");

            var localVarPath = "/api/v2/conversations/calls/{conversationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCall: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCall: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallConversation>(localVarStatusCode,
                localVarHeaders,
                (CallConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallConversation)));
            
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Wrapup</returns>
        public Wrapup GetConversationsCallParticipantWrapup (string conversationId, string participantId, bool? provisional = null)
        {
             ApiResponse<Wrapup> localVarResponse = GetConversationsCallParticipantWrapupWithHttpInfo(conversationId, participantId, provisional);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>ApiResponse of Wrapup</returns>
        public ApiResponse< Wrapup > GetConversationsCallParticipantWrapupWithHttpInfo (string conversationId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationsCallParticipantWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetConversationsCallParticipantWrapup");

            var localVarPath = "/api/v2/conversations/calls/{conversationId}/participants/{participantId}/wrapup";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (provisional != null) localVarQueryParams.Add("provisional", Configuration.ApiClient.ParameterToString(provisional)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCallParticipantWrapup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCallParticipantWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Wrapup>(localVarStatusCode,
                localVarHeaders,
                (Wrapup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Wrapup)));
            
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of Wrapup</returns>
        public async System.Threading.Tasks.Task<Wrapup> GetConversationsCallParticipantWrapupAsync (string conversationId, string participantId, bool? provisional = null)
        {
             ApiResponse<Wrapup> localVarResponse = await GetConversationsCallParticipantWrapupAsyncWithHttpInfo(conversationId, participantId, provisional);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (Wrapup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Wrapup>> GetConversationsCallParticipantWrapupAsyncWithHttpInfo (string conversationId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationsCallParticipantWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetConversationsCallParticipantWrapup");

            var localVarPath = "/api/v2/conversations/calls/{conversationId}/participants/{participantId}/wrapup";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (provisional != null) localVarQueryParams.Add("provisional", Configuration.ApiClient.ParameterToString(provisional)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCallParticipantWrapup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCallParticipantWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Wrapup>(localVarStatusCode,
                localVarHeaders,
                (Wrapup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Wrapup)));
            
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>List&lt;WrapupCode&gt;</returns>
        public List<WrapupCode> GetConversationsCallParticipantWrapupcodes (string conversationId, string participantId)
        {
             ApiResponse<List<WrapupCode>> localVarResponse = GetConversationsCallParticipantWrapupcodesWithHttpInfo(conversationId, participantId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>ApiResponse of List&lt;WrapupCode&gt;</returns>
        public ApiResponse< List<WrapupCode> > GetConversationsCallParticipantWrapupcodesWithHttpInfo (string conversationId, string participantId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationsCallParticipantWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetConversationsCallParticipantWrapupcodes");

            var localVarPath = "/api/v2/conversations/calls/{conversationId}/participants/{participantId}/wrapupcodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCallParticipantWrapupcodes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCallParticipantWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WrapupCode>>(localVarStatusCode,
                localVarHeaders,
                (List<WrapupCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WrapupCode>)));
            
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of List&lt;WrapupCode&gt;</returns>
        public async System.Threading.Tasks.Task<List<WrapupCode>> GetConversationsCallParticipantWrapupcodesAsync (string conversationId, string participantId)
        {
             ApiResponse<List<WrapupCode>> localVarResponse = await GetConversationsCallParticipantWrapupcodesAsyncWithHttpInfo(conversationId, participantId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of ApiResponse (List&lt;WrapupCode&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<WrapupCode>>> GetConversationsCallParticipantWrapupcodesAsyncWithHttpInfo (string conversationId, string participantId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationsCallParticipantWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetConversationsCallParticipantWrapupcodes");

            var localVarPath = "/api/v2/conversations/calls/{conversationId}/participants/{participantId}/wrapupcodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCallParticipantWrapupcodes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCallParticipantWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WrapupCode>>(localVarStatusCode,
                localVarHeaders,
                (List<WrapupCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WrapupCode>)));
            
        }

        /// <summary>
        /// Get callback conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>CallbackConversation</returns>
        public CallbackConversation GetConversationsCallback (string conversationId)
        {
             ApiResponse<CallbackConversation> localVarResponse = GetConversationsCallbackWithHttpInfo(conversationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get callback conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>ApiResponse of CallbackConversation</returns>
        public ApiResponse< CallbackConversation > GetConversationsCallbackWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationsCallback");

            var localVarPath = "/api/v2/conversations/callbacks/{conversationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCallback: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCallback: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallbackConversation>(localVarStatusCode,
                localVarHeaders,
                (CallbackConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallbackConversation)));
            
        }

        /// <summary>
        /// Get callback conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of CallbackConversation</returns>
        public async System.Threading.Tasks.Task<CallbackConversation> GetConversationsCallbackAsync (string conversationId)
        {
             ApiResponse<CallbackConversation> localVarResponse = await GetConversationsCallbackAsyncWithHttpInfo(conversationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get callback conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of ApiResponse (CallbackConversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallbackConversation>> GetConversationsCallbackAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationsCallback");

            var localVarPath = "/api/v2/conversations/callbacks/{conversationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCallback: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCallback: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallbackConversation>(localVarStatusCode,
                localVarHeaders,
                (CallbackConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallbackConversation)));
            
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Wrapup</returns>
        public Wrapup GetConversationsCallbackParticipantWrapup (string conversationId, string participantId, bool? provisional = null)
        {
             ApiResponse<Wrapup> localVarResponse = GetConversationsCallbackParticipantWrapupWithHttpInfo(conversationId, participantId, provisional);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>ApiResponse of Wrapup</returns>
        public ApiResponse< Wrapup > GetConversationsCallbackParticipantWrapupWithHttpInfo (string conversationId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationsCallbackParticipantWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetConversationsCallbackParticipantWrapup");

            var localVarPath = "/api/v2/conversations/callbacks/{conversationId}/participants/{participantId}/wrapup";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (provisional != null) localVarQueryParams.Add("provisional", Configuration.ApiClient.ParameterToString(provisional)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCallbackParticipantWrapup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCallbackParticipantWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Wrapup>(localVarStatusCode,
                localVarHeaders,
                (Wrapup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Wrapup)));
            
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of Wrapup</returns>
        public async System.Threading.Tasks.Task<Wrapup> GetConversationsCallbackParticipantWrapupAsync (string conversationId, string participantId, bool? provisional = null)
        {
             ApiResponse<Wrapup> localVarResponse = await GetConversationsCallbackParticipantWrapupAsyncWithHttpInfo(conversationId, participantId, provisional);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (Wrapup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Wrapup>> GetConversationsCallbackParticipantWrapupAsyncWithHttpInfo (string conversationId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationsCallbackParticipantWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetConversationsCallbackParticipantWrapup");

            var localVarPath = "/api/v2/conversations/callbacks/{conversationId}/participants/{participantId}/wrapup";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (provisional != null) localVarQueryParams.Add("provisional", Configuration.ApiClient.ParameterToString(provisional)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCallbackParticipantWrapup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCallbackParticipantWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Wrapup>(localVarStatusCode,
                localVarHeaders,
                (Wrapup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Wrapup)));
            
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>List&lt;WrapupCode&gt;</returns>
        public List<WrapupCode> GetConversationsCallbackParticipantWrapupcodes (string conversationId, string participantId)
        {
             ApiResponse<List<WrapupCode>> localVarResponse = GetConversationsCallbackParticipantWrapupcodesWithHttpInfo(conversationId, participantId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>ApiResponse of List&lt;WrapupCode&gt;</returns>
        public ApiResponse< List<WrapupCode> > GetConversationsCallbackParticipantWrapupcodesWithHttpInfo (string conversationId, string participantId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationsCallbackParticipantWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetConversationsCallbackParticipantWrapupcodes");

            var localVarPath = "/api/v2/conversations/callbacks/{conversationId}/participants/{participantId}/wrapupcodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCallbackParticipantWrapupcodes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCallbackParticipantWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WrapupCode>>(localVarStatusCode,
                localVarHeaders,
                (List<WrapupCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WrapupCode>)));
            
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of List&lt;WrapupCode&gt;</returns>
        public async System.Threading.Tasks.Task<List<WrapupCode>> GetConversationsCallbackParticipantWrapupcodesAsync (string conversationId, string participantId)
        {
             ApiResponse<List<WrapupCode>> localVarResponse = await GetConversationsCallbackParticipantWrapupcodesAsyncWithHttpInfo(conversationId, participantId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of ApiResponse (List&lt;WrapupCode&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<WrapupCode>>> GetConversationsCallbackParticipantWrapupcodesAsyncWithHttpInfo (string conversationId, string participantId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationsCallbackParticipantWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetConversationsCallbackParticipantWrapupcodes");

            var localVarPath = "/api/v2/conversations/callbacks/{conversationId}/participants/{participantId}/wrapupcodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCallbackParticipantWrapupcodes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCallbackParticipantWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WrapupCode>>(localVarStatusCode,
                localVarHeaders,
                (List<WrapupCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WrapupCode>)));
            
        }

        /// <summary>
        /// Get callback conversations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CallbackConversationEntityListing</returns>
        public CallbackConversationEntityListing GetConversationsCallbacks ()
        {
             ApiResponse<CallbackConversationEntityListing> localVarResponse = GetConversationsCallbacksWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get callback conversations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CallbackConversationEntityListing</returns>
        public ApiResponse< CallbackConversationEntityListing > GetConversationsCallbacksWithHttpInfo ()
        {

            var localVarPath = "/api/v2/conversations/callbacks";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCallbacks: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCallbacks: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallbackConversationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (CallbackConversationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallbackConversationEntityListing)));
            
        }

        /// <summary>
        /// Get callback conversations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of CallbackConversationEntityListing</returns>
        public async System.Threading.Tasks.Task<CallbackConversationEntityListing> GetConversationsCallbacksAsync ()
        {
             ApiResponse<CallbackConversationEntityListing> localVarResponse = await GetConversationsCallbacksAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get callback conversations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (CallbackConversationEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallbackConversationEntityListing>> GetConversationsCallbacksAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/conversations/callbacks";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCallbacks: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCallbacks: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallbackConversationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (CallbackConversationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallbackConversationEntityListing)));
            
        }

        /// <summary>
        /// Get recent conversations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CallConversationEntityListing</returns>
        public CallConversationEntityListing GetConversationsCalls ()
        {
             ApiResponse<CallConversationEntityListing> localVarResponse = GetConversationsCallsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get recent conversations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CallConversationEntityListing</returns>
        public ApiResponse< CallConversationEntityListing > GetConversationsCallsWithHttpInfo ()
        {

            var localVarPath = "/api/v2/conversations/calls";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCalls: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCalls: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallConversationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (CallConversationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallConversationEntityListing)));
            
        }

        /// <summary>
        /// Get recent conversations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of CallConversationEntityListing</returns>
        public async System.Threading.Tasks.Task<CallConversationEntityListing> GetConversationsCallsAsync ()
        {
             ApiResponse<CallConversationEntityListing> localVarResponse = await GetConversationsCallsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get recent conversations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (CallConversationEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallConversationEntityListing>> GetConversationsCallsAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/conversations/calls";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCalls: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCalls: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallConversationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (CallConversationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallConversationEntityListing)));
            
        }

        /// <summary>
        /// Get call history 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="interval">Interval string; format is ISO-8601. Separate start and end times with forward slash &#39;/&#39; (optional)</param>
        /// <returns>CallConversationEntityListing</returns>
        public CallConversationEntityListing GetConversationsCallsHistory (int? pageSize = null, int? pageNumber = null, string interval = null)
        {
             ApiResponse<CallConversationEntityListing> localVarResponse = GetConversationsCallsHistoryWithHttpInfo(pageSize, pageNumber, interval);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get call history 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="interval">Interval string; format is ISO-8601. Separate start and end times with forward slash &#39;/&#39; (optional)</param>
        /// <returns>ApiResponse of CallConversationEntityListing</returns>
        public ApiResponse< CallConversationEntityListing > GetConversationsCallsHistoryWithHttpInfo (int? pageSize = null, int? pageNumber = null, string interval = null)
        {

            var localVarPath = "/api/v2/conversations/calls/history";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (interval != null) localVarQueryParams.Add("interval", Configuration.ApiClient.ParameterToString(interval)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCallsHistory: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCallsHistory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallConversationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (CallConversationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallConversationEntityListing)));
            
        }

        /// <summary>
        /// Get call history 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="interval">Interval string; format is ISO-8601. Separate start and end times with forward slash &#39;/&#39; (optional)</param>
        /// <returns>Task of CallConversationEntityListing</returns>
        public async System.Threading.Tasks.Task<CallConversationEntityListing> GetConversationsCallsHistoryAsync (int? pageSize = null, int? pageNumber = null, string interval = null)
        {
             ApiResponse<CallConversationEntityListing> localVarResponse = await GetConversationsCallsHistoryAsyncWithHttpInfo(pageSize, pageNumber, interval);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get call history 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="interval">Interval string; format is ISO-8601. Separate start and end times with forward slash &#39;/&#39; (optional)</param>
        /// <returns>Task of ApiResponse (CallConversationEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallConversationEntityListing>> GetConversationsCallsHistoryAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string interval = null)
        {

            var localVarPath = "/api/v2/conversations/calls/history";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (interval != null) localVarQueryParams.Add("interval", Configuration.ApiClient.ParameterToString(interval)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCallsHistory: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCallsHistory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallConversationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (CallConversationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallConversationEntityListing)));
            
        }

        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>MaxParticipants</returns>
        public MaxParticipants GetConversationsCallsMaximumconferenceparties ()
        {
             ApiResponse<MaxParticipants> localVarResponse = GetConversationsCallsMaximumconferencepartiesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of MaxParticipants</returns>
        public ApiResponse< MaxParticipants > GetConversationsCallsMaximumconferencepartiesWithHttpInfo ()
        {

            var localVarPath = "/api/v2/conversations/calls/maximumconferenceparties";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCallsMaximumconferenceparties: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCallsMaximumconferenceparties: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MaxParticipants>(localVarStatusCode,
                localVarHeaders,
                (MaxParticipants) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaxParticipants)));
            
        }

        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of MaxParticipants</returns>
        public async System.Threading.Tasks.Task<MaxParticipants> GetConversationsCallsMaximumconferencepartiesAsync ()
        {
             ApiResponse<MaxParticipants> localVarResponse = await GetConversationsCallsMaximumconferencepartiesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (MaxParticipants)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MaxParticipants>> GetConversationsCallsMaximumconferencepartiesAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/conversations/calls/maximumconferenceparties";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCallsMaximumconferenceparties: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCallsMaximumconferenceparties: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MaxParticipants>(localVarStatusCode,
                localVarHeaders,
                (MaxParticipants) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaxParticipants)));
            
        }

        /// <summary>
        /// Get chat conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>ChatConversation</returns>
        public ChatConversation GetConversationsChat (string conversationId)
        {
             ApiResponse<ChatConversation> localVarResponse = GetConversationsChatWithHttpInfo(conversationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get chat conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>ApiResponse of ChatConversation</returns>
        public ApiResponse< ChatConversation > GetConversationsChatWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationsChat");

            var localVarPath = "/api/v2/conversations/chats/{conversationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsChat: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsChat: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatConversation>(localVarStatusCode,
                localVarHeaders,
                (ChatConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatConversation)));
            
        }

        /// <summary>
        /// Get chat conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of ChatConversation</returns>
        public async System.Threading.Tasks.Task<ChatConversation> GetConversationsChatAsync (string conversationId)
        {
             ApiResponse<ChatConversation> localVarResponse = await GetConversationsChatAsyncWithHttpInfo(conversationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get chat conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of ApiResponse (ChatConversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ChatConversation>> GetConversationsChatAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationsChat");

            var localVarPath = "/api/v2/conversations/chats/{conversationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsChat: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsChat: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatConversation>(localVarStatusCode,
                localVarHeaders,
                (ChatConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatConversation)));
            
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Wrapup</returns>
        public Wrapup GetConversationsChatParticipantWrapup (string conversationId, string participantId, bool? provisional = null)
        {
             ApiResponse<Wrapup> localVarResponse = GetConversationsChatParticipantWrapupWithHttpInfo(conversationId, participantId, provisional);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>ApiResponse of Wrapup</returns>
        public ApiResponse< Wrapup > GetConversationsChatParticipantWrapupWithHttpInfo (string conversationId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationsChatParticipantWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetConversationsChatParticipantWrapup");

            var localVarPath = "/api/v2/conversations/chats/{conversationId}/participants/{participantId}/wrapup";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (provisional != null) localVarQueryParams.Add("provisional", Configuration.ApiClient.ParameterToString(provisional)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsChatParticipantWrapup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsChatParticipantWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Wrapup>(localVarStatusCode,
                localVarHeaders,
                (Wrapup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Wrapup)));
            
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of Wrapup</returns>
        public async System.Threading.Tasks.Task<Wrapup> GetConversationsChatParticipantWrapupAsync (string conversationId, string participantId, bool? provisional = null)
        {
             ApiResponse<Wrapup> localVarResponse = await GetConversationsChatParticipantWrapupAsyncWithHttpInfo(conversationId, participantId, provisional);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (Wrapup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Wrapup>> GetConversationsChatParticipantWrapupAsyncWithHttpInfo (string conversationId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationsChatParticipantWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetConversationsChatParticipantWrapup");

            var localVarPath = "/api/v2/conversations/chats/{conversationId}/participants/{participantId}/wrapup";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (provisional != null) localVarQueryParams.Add("provisional", Configuration.ApiClient.ParameterToString(provisional)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsChatParticipantWrapup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsChatParticipantWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Wrapup>(localVarStatusCode,
                localVarHeaders,
                (Wrapup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Wrapup)));
            
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>List&lt;WrapupCode&gt;</returns>
        public List<WrapupCode> GetConversationsChatParticipantWrapupcodes (string conversationId, string participantId)
        {
             ApiResponse<List<WrapupCode>> localVarResponse = GetConversationsChatParticipantWrapupcodesWithHttpInfo(conversationId, participantId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>ApiResponse of List&lt;WrapupCode&gt;</returns>
        public ApiResponse< List<WrapupCode> > GetConversationsChatParticipantWrapupcodesWithHttpInfo (string conversationId, string participantId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationsChatParticipantWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetConversationsChatParticipantWrapupcodes");

            var localVarPath = "/api/v2/conversations/chats/{conversationId}/participants/{participantId}/wrapupcodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsChatParticipantWrapupcodes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsChatParticipantWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WrapupCode>>(localVarStatusCode,
                localVarHeaders,
                (List<WrapupCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WrapupCode>)));
            
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of List&lt;WrapupCode&gt;</returns>
        public async System.Threading.Tasks.Task<List<WrapupCode>> GetConversationsChatParticipantWrapupcodesAsync (string conversationId, string participantId)
        {
             ApiResponse<List<WrapupCode>> localVarResponse = await GetConversationsChatParticipantWrapupcodesAsyncWithHttpInfo(conversationId, participantId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of ApiResponse (List&lt;WrapupCode&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<WrapupCode>>> GetConversationsChatParticipantWrapupcodesAsyncWithHttpInfo (string conversationId, string participantId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationsChatParticipantWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetConversationsChatParticipantWrapupcodes");

            var localVarPath = "/api/v2/conversations/chats/{conversationId}/participants/{participantId}/wrapupcodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsChatParticipantWrapupcodes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsChatParticipantWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WrapupCode>>(localVarStatusCode,
                localVarHeaders,
                (List<WrapupCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WrapupCode>)));
            
        }

        /// <summary>
        /// Get recent chat conversations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ChatConversationEntityListing</returns>
        public ChatConversationEntityListing GetConversationsChats ()
        {
             ApiResponse<ChatConversationEntityListing> localVarResponse = GetConversationsChatsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get recent chat conversations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ChatConversationEntityListing</returns>
        public ApiResponse< ChatConversationEntityListing > GetConversationsChatsWithHttpInfo ()
        {

            var localVarPath = "/api/v2/conversations/chats";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsChats: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsChats: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatConversationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ChatConversationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatConversationEntityListing)));
            
        }

        /// <summary>
        /// Get recent chat conversations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ChatConversationEntityListing</returns>
        public async System.Threading.Tasks.Task<ChatConversationEntityListing> GetConversationsChatsAsync ()
        {
             ApiResponse<ChatConversationEntityListing> localVarResponse = await GetConversationsChatsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get recent chat conversations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ChatConversationEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ChatConversationEntityListing>> GetConversationsChatsAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/conversations/chats";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsChats: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsChats: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatConversationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ChatConversationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatConversationEntityListing)));
            
        }

        /// <summary>
        /// Get cobrowse conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>CobrowseConversation</returns>
        public CobrowseConversation GetConversationsCobrowsesession (string conversationId)
        {
             ApiResponse<CobrowseConversation> localVarResponse = GetConversationsCobrowsesessionWithHttpInfo(conversationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get cobrowse conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>ApiResponse of CobrowseConversation</returns>
        public ApiResponse< CobrowseConversation > GetConversationsCobrowsesessionWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationsCobrowsesession");

            var localVarPath = "/api/v2/conversations/cobrowsesessions/{conversationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCobrowsesession: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCobrowsesession: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CobrowseConversation>(localVarStatusCode,
                localVarHeaders,
                (CobrowseConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CobrowseConversation)));
            
        }

        /// <summary>
        /// Get cobrowse conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of CobrowseConversation</returns>
        public async System.Threading.Tasks.Task<CobrowseConversation> GetConversationsCobrowsesessionAsync (string conversationId)
        {
             ApiResponse<CobrowseConversation> localVarResponse = await GetConversationsCobrowsesessionAsyncWithHttpInfo(conversationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get cobrowse conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of ApiResponse (CobrowseConversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CobrowseConversation>> GetConversationsCobrowsesessionAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationsCobrowsesession");

            var localVarPath = "/api/v2/conversations/cobrowsesessions/{conversationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCobrowsesession: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCobrowsesession: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CobrowseConversation>(localVarStatusCode,
                localVarHeaders,
                (CobrowseConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CobrowseConversation)));
            
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Wrapup</returns>
        public Wrapup GetConversationsCobrowsesessionParticipantWrapup (string conversationId, string participantId, bool? provisional = null)
        {
             ApiResponse<Wrapup> localVarResponse = GetConversationsCobrowsesessionParticipantWrapupWithHttpInfo(conversationId, participantId, provisional);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>ApiResponse of Wrapup</returns>
        public ApiResponse< Wrapup > GetConversationsCobrowsesessionParticipantWrapupWithHttpInfo (string conversationId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationsCobrowsesessionParticipantWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetConversationsCobrowsesessionParticipantWrapup");

            var localVarPath = "/api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId}/wrapup";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (provisional != null) localVarQueryParams.Add("provisional", Configuration.ApiClient.ParameterToString(provisional)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCobrowsesessionParticipantWrapup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCobrowsesessionParticipantWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Wrapup>(localVarStatusCode,
                localVarHeaders,
                (Wrapup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Wrapup)));
            
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of Wrapup</returns>
        public async System.Threading.Tasks.Task<Wrapup> GetConversationsCobrowsesessionParticipantWrapupAsync (string conversationId, string participantId, bool? provisional = null)
        {
             ApiResponse<Wrapup> localVarResponse = await GetConversationsCobrowsesessionParticipantWrapupAsyncWithHttpInfo(conversationId, participantId, provisional);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (Wrapup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Wrapup>> GetConversationsCobrowsesessionParticipantWrapupAsyncWithHttpInfo (string conversationId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationsCobrowsesessionParticipantWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetConversationsCobrowsesessionParticipantWrapup");

            var localVarPath = "/api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId}/wrapup";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (provisional != null) localVarQueryParams.Add("provisional", Configuration.ApiClient.ParameterToString(provisional)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCobrowsesessionParticipantWrapup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCobrowsesessionParticipantWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Wrapup>(localVarStatusCode,
                localVarHeaders,
                (Wrapup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Wrapup)));
            
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>List&lt;WrapupCode&gt;</returns>
        public List<WrapupCode> GetConversationsCobrowsesessionParticipantWrapupcodes (string conversationId, string participantId)
        {
             ApiResponse<List<WrapupCode>> localVarResponse = GetConversationsCobrowsesessionParticipantWrapupcodesWithHttpInfo(conversationId, participantId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>ApiResponse of List&lt;WrapupCode&gt;</returns>
        public ApiResponse< List<WrapupCode> > GetConversationsCobrowsesessionParticipantWrapupcodesWithHttpInfo (string conversationId, string participantId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationsCobrowsesessionParticipantWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetConversationsCobrowsesessionParticipantWrapupcodes");

            var localVarPath = "/api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId}/wrapupcodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCobrowsesessionParticipantWrapupcodes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCobrowsesessionParticipantWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WrapupCode>>(localVarStatusCode,
                localVarHeaders,
                (List<WrapupCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WrapupCode>)));
            
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of List&lt;WrapupCode&gt;</returns>
        public async System.Threading.Tasks.Task<List<WrapupCode>> GetConversationsCobrowsesessionParticipantWrapupcodesAsync (string conversationId, string participantId)
        {
             ApiResponse<List<WrapupCode>> localVarResponse = await GetConversationsCobrowsesessionParticipantWrapupcodesAsyncWithHttpInfo(conversationId, participantId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of ApiResponse (List&lt;WrapupCode&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<WrapupCode>>> GetConversationsCobrowsesessionParticipantWrapupcodesAsyncWithHttpInfo (string conversationId, string participantId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationsCobrowsesessionParticipantWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetConversationsCobrowsesessionParticipantWrapupcodes");

            var localVarPath = "/api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId}/wrapupcodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCobrowsesessionParticipantWrapupcodes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCobrowsesessionParticipantWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WrapupCode>>(localVarStatusCode,
                localVarHeaders,
                (List<WrapupCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WrapupCode>)));
            
        }

        /// <summary>
        /// Get recent cobrowse conversations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CobrowseConversationEntityListing</returns>
        public CobrowseConversationEntityListing GetConversationsCobrowsesessions ()
        {
             ApiResponse<CobrowseConversationEntityListing> localVarResponse = GetConversationsCobrowsesessionsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get recent cobrowse conversations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CobrowseConversationEntityListing</returns>
        public ApiResponse< CobrowseConversationEntityListing > GetConversationsCobrowsesessionsWithHttpInfo ()
        {

            var localVarPath = "/api/v2/conversations/cobrowsesessions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCobrowsesessions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCobrowsesessions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CobrowseConversationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (CobrowseConversationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CobrowseConversationEntityListing)));
            
        }

        /// <summary>
        /// Get recent cobrowse conversations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of CobrowseConversationEntityListing</returns>
        public async System.Threading.Tasks.Task<CobrowseConversationEntityListing> GetConversationsCobrowsesessionsAsync ()
        {
             ApiResponse<CobrowseConversationEntityListing> localVarResponse = await GetConversationsCobrowsesessionsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get recent cobrowse conversations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (CobrowseConversationEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CobrowseConversationEntityListing>> GetConversationsCobrowsesessionsAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/conversations/cobrowsesessions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCobrowsesessions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsCobrowsesessions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CobrowseConversationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (CobrowseConversationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CobrowseConversationEntityListing)));
            
        }

        /// <summary>
        /// Get email conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>EmailConversation</returns>
        public EmailConversation GetConversationsEmail (string conversationId)
        {
             ApiResponse<EmailConversation> localVarResponse = GetConversationsEmailWithHttpInfo(conversationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get email conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>ApiResponse of EmailConversation</returns>
        public ApiResponse< EmailConversation > GetConversationsEmailWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationsEmail");

            var localVarPath = "/api/v2/conversations/emails/{conversationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsEmail: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsEmail: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailConversation>(localVarStatusCode,
                localVarHeaders,
                (EmailConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailConversation)));
            
        }

        /// <summary>
        /// Get email conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of EmailConversation</returns>
        public async System.Threading.Tasks.Task<EmailConversation> GetConversationsEmailAsync (string conversationId)
        {
             ApiResponse<EmailConversation> localVarResponse = await GetConversationsEmailAsyncWithHttpInfo(conversationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get email conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of ApiResponse (EmailConversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailConversation>> GetConversationsEmailAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationsEmail");

            var localVarPath = "/api/v2/conversations/emails/{conversationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsEmail: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsEmail: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailConversation>(localVarStatusCode,
                localVarHeaders,
                (EmailConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailConversation)));
            
        }

        /// <summary>
        /// Get conversation message 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>EmailMessage</returns>
        public EmailMessage GetConversationsEmailMessage (string conversationId, string messageId)
        {
             ApiResponse<EmailMessage> localVarResponse = GetConversationsEmailMessageWithHttpInfo(conversationId, messageId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get conversation message 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        public ApiResponse< EmailMessage > GetConversationsEmailMessageWithHttpInfo (string conversationId, string messageId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationsEmailMessage");
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling ConversationsApi->GetConversationsEmailMessage");

            var localVarPath = "/api/v2/conversations/emails/{conversationId}/messages/{messageId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (messageId != null) localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsEmailMessage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsEmailMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarHeaders,
                (EmailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessage)));
            
        }

        /// <summary>
        /// Get conversation message 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>Task of EmailMessage</returns>
        public async System.Threading.Tasks.Task<EmailMessage> GetConversationsEmailMessageAsync (string conversationId, string messageId)
        {
             ApiResponse<EmailMessage> localVarResponse = await GetConversationsEmailMessageAsyncWithHttpInfo(conversationId, messageId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get conversation message 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessage>> GetConversationsEmailMessageAsyncWithHttpInfo (string conversationId, string messageId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationsEmailMessage");
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling ConversationsApi->GetConversationsEmailMessage");

            var localVarPath = "/api/v2/conversations/emails/{conversationId}/messages/{messageId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (messageId != null) localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsEmailMessage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsEmailMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarHeaders,
                (EmailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessage)));
            
        }

        /// <summary>
        /// Get conversation messages 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>EmailMessageListing</returns>
        public EmailMessageListing GetConversationsEmailMessages (string conversationId)
        {
             ApiResponse<EmailMessageListing> localVarResponse = GetConversationsEmailMessagesWithHttpInfo(conversationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get conversation messages 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>ApiResponse of EmailMessageListing</returns>
        public ApiResponse< EmailMessageListing > GetConversationsEmailMessagesWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationsEmailMessages");

            var localVarPath = "/api/v2/conversations/emails/{conversationId}/messages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsEmailMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsEmailMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessageListing>(localVarStatusCode,
                localVarHeaders,
                (EmailMessageListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessageListing)));
            
        }

        /// <summary>
        /// Get conversation messages 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of EmailMessageListing</returns>
        public async System.Threading.Tasks.Task<EmailMessageListing> GetConversationsEmailMessagesAsync (string conversationId)
        {
             ApiResponse<EmailMessageListing> localVarResponse = await GetConversationsEmailMessagesAsyncWithHttpInfo(conversationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get conversation messages 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of ApiResponse (EmailMessageListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessageListing>> GetConversationsEmailMessagesAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationsEmailMessages");

            var localVarPath = "/api/v2/conversations/emails/{conversationId}/messages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsEmailMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsEmailMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessageListing>(localVarStatusCode,
                localVarHeaders,
                (EmailMessageListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessageListing)));
            
        }

        /// <summary>
        /// Get conversation draft reply 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>EmailMessage</returns>
        public EmailMessage GetConversationsEmailMessagesDraft (string conversationId)
        {
             ApiResponse<EmailMessage> localVarResponse = GetConversationsEmailMessagesDraftWithHttpInfo(conversationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get conversation draft reply 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        public ApiResponse< EmailMessage > GetConversationsEmailMessagesDraftWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationsEmailMessagesDraft");

            var localVarPath = "/api/v2/conversations/emails/{conversationId}/messages/draft";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsEmailMessagesDraft: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsEmailMessagesDraft: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarHeaders,
                (EmailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessage)));
            
        }

        /// <summary>
        /// Get conversation draft reply 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of EmailMessage</returns>
        public async System.Threading.Tasks.Task<EmailMessage> GetConversationsEmailMessagesDraftAsync (string conversationId)
        {
             ApiResponse<EmailMessage> localVarResponse = await GetConversationsEmailMessagesDraftAsyncWithHttpInfo(conversationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get conversation draft reply 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessage>> GetConversationsEmailMessagesDraftAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationsEmailMessagesDraft");

            var localVarPath = "/api/v2/conversations/emails/{conversationId}/messages/draft";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsEmailMessagesDraft: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsEmailMessagesDraft: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarHeaders,
                (EmailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessage)));
            
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Wrapup</returns>
        public Wrapup GetConversationsEmailParticipantWrapup (string conversationId, string participantId, bool? provisional = null)
        {
             ApiResponse<Wrapup> localVarResponse = GetConversationsEmailParticipantWrapupWithHttpInfo(conversationId, participantId, provisional);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>ApiResponse of Wrapup</returns>
        public ApiResponse< Wrapup > GetConversationsEmailParticipantWrapupWithHttpInfo (string conversationId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationsEmailParticipantWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetConversationsEmailParticipantWrapup");

            var localVarPath = "/api/v2/conversations/emails/{conversationId}/participants/{participantId}/wrapup";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (provisional != null) localVarQueryParams.Add("provisional", Configuration.ApiClient.ParameterToString(provisional)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsEmailParticipantWrapup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsEmailParticipantWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Wrapup>(localVarStatusCode,
                localVarHeaders,
                (Wrapup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Wrapup)));
            
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of Wrapup</returns>
        public async System.Threading.Tasks.Task<Wrapup> GetConversationsEmailParticipantWrapupAsync (string conversationId, string participantId, bool? provisional = null)
        {
             ApiResponse<Wrapup> localVarResponse = await GetConversationsEmailParticipantWrapupAsyncWithHttpInfo(conversationId, participantId, provisional);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (Wrapup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Wrapup>> GetConversationsEmailParticipantWrapupAsyncWithHttpInfo (string conversationId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationsEmailParticipantWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetConversationsEmailParticipantWrapup");

            var localVarPath = "/api/v2/conversations/emails/{conversationId}/participants/{participantId}/wrapup";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (provisional != null) localVarQueryParams.Add("provisional", Configuration.ApiClient.ParameterToString(provisional)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsEmailParticipantWrapup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsEmailParticipantWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Wrapup>(localVarStatusCode,
                localVarHeaders,
                (Wrapup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Wrapup)));
            
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>List&lt;WrapupCode&gt;</returns>
        public List<WrapupCode> GetConversationsEmailParticipantWrapupcodes (string conversationId, string participantId)
        {
             ApiResponse<List<WrapupCode>> localVarResponse = GetConversationsEmailParticipantWrapupcodesWithHttpInfo(conversationId, participantId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>ApiResponse of List&lt;WrapupCode&gt;</returns>
        public ApiResponse< List<WrapupCode> > GetConversationsEmailParticipantWrapupcodesWithHttpInfo (string conversationId, string participantId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationsEmailParticipantWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetConversationsEmailParticipantWrapupcodes");

            var localVarPath = "/api/v2/conversations/emails/{conversationId}/participants/{participantId}/wrapupcodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsEmailParticipantWrapupcodes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsEmailParticipantWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WrapupCode>>(localVarStatusCode,
                localVarHeaders,
                (List<WrapupCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WrapupCode>)));
            
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of List&lt;WrapupCode&gt;</returns>
        public async System.Threading.Tasks.Task<List<WrapupCode>> GetConversationsEmailParticipantWrapupcodesAsync (string conversationId, string participantId)
        {
             ApiResponse<List<WrapupCode>> localVarResponse = await GetConversationsEmailParticipantWrapupcodesAsyncWithHttpInfo(conversationId, participantId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of ApiResponse (List&lt;WrapupCode&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<WrapupCode>>> GetConversationsEmailParticipantWrapupcodesAsyncWithHttpInfo (string conversationId, string participantId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationsEmailParticipantWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetConversationsEmailParticipantWrapupcodes");

            var localVarPath = "/api/v2/conversations/emails/{conversationId}/participants/{participantId}/wrapupcodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsEmailParticipantWrapupcodes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsEmailParticipantWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WrapupCode>>(localVarStatusCode,
                localVarHeaders,
                (List<WrapupCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WrapupCode>)));
            
        }

        /// <summary>
        /// Get recent email conversations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>EmailConversationEntityListing</returns>
        public EmailConversationEntityListing GetConversationsEmails ()
        {
             ApiResponse<EmailConversationEntityListing> localVarResponse = GetConversationsEmailsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get recent email conversations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of EmailConversationEntityListing</returns>
        public ApiResponse< EmailConversationEntityListing > GetConversationsEmailsWithHttpInfo ()
        {

            var localVarPath = "/api/v2/conversations/emails";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsEmails: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsEmails: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailConversationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (EmailConversationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailConversationEntityListing)));
            
        }

        /// <summary>
        /// Get recent email conversations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of EmailConversationEntityListing</returns>
        public async System.Threading.Tasks.Task<EmailConversationEntityListing> GetConversationsEmailsAsync ()
        {
             ApiResponse<EmailConversationEntityListing> localVarResponse = await GetConversationsEmailsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get recent email conversations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (EmailConversationEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailConversationEntityListing>> GetConversationsEmailsAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/conversations/emails";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsEmails: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsEmails: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailConversationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (EmailConversationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailConversationEntityListing)));
            
        }

        /// <summary>
        /// Update a participant. Update conversation participant.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Update request</param>
        /// <returns></returns>
        public void PatchConversationParticipant (string conversationId, string participantId, MediaParticipantRequest body)
        {
             PatchConversationParticipantWithHttpInfo(conversationId, participantId, body);
        }

        /// <summary>
        /// Update a participant. Update conversation participant.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Update request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchConversationParticipantWithHttpInfo (string conversationId, string participantId, MediaParticipantRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationParticipant");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationParticipant");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationParticipant");

            var localVarPath = "/api/v2/conversations/{conversationId}/participants/{participantId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationParticipant: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationParticipant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update a participant. Update conversation participant.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Update request</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchConversationParticipantAsync (string conversationId, string participantId, MediaParticipantRequest body)
        {
             await PatchConversationParticipantAsyncWithHttpInfo(conversationId, participantId, body);

        }

        /// <summary>
        /// Update a participant. Update conversation participant.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Update request</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchConversationParticipantAsyncWithHttpInfo (string conversationId, string participantId, MediaParticipantRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationParticipant");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationParticipant");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationParticipant");

            var localVarPath = "/api/v2/conversations/{conversationId}/participants/{participantId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationParticipant: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationParticipant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Participant attributes</param>
        /// <returns></returns>
        public void PatchConversationParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body)
        {
             PatchConversationParticipantAttributesWithHttpInfo(conversationId, participantId, body);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchConversationParticipantAttributesWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationParticipantAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationParticipantAttributes");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationParticipantAttributes");

            var localVarPath = "/api/v2/conversations/{conversationId}/participants/{participantId}/attributes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationParticipantAttributes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationParticipantAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchConversationParticipantAttributesAsync (string conversationId, string participantId, ParticipantAttributes body)
        {
             await PatchConversationParticipantAttributesAsyncWithHttpInfo(conversationId, participantId, body);

        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchConversationParticipantAttributesAsyncWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationParticipantAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationParticipantAttributes");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationParticipantAttributes");

            var localVarPath = "/api/v2/conversations/{conversationId}/participants/{participantId}/attributes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationParticipantAttributes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationParticipantAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update a conversation by setting it&#39;s recording state, merging in other conversations to create a conference, or disconnecting all of the participants 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        public Conversation PatchConversationsCall (string conversationId, Conversation body)
        {
             ApiResponse<Conversation> localVarResponse = PatchConversationsCallWithHttpInfo(conversationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a conversation by setting it&#39;s recording state, merging in other conversations to create a conference, or disconnecting all of the participants 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        public ApiResponse< Conversation > PatchConversationsCallWithHttpInfo (string conversationId, Conversation body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsCall");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationsCall");

            var localVarPath = "/api/v2/conversations/calls/{conversationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCall: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCall: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarHeaders,
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Update a conversation by setting it&#39;s recording state, merging in other conversations to create a conference, or disconnecting all of the participants 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        public async System.Threading.Tasks.Task<Conversation> PatchConversationsCallAsync (string conversationId, Conversation body)
        {
             ApiResponse<Conversation> localVarResponse = await PatchConversationsCallAsyncWithHttpInfo(conversationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a conversation by setting it&#39;s recording state, merging in other conversations to create a conference, or disconnecting all of the participants 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conversation>> PatchConversationsCallAsyncWithHttpInfo (string conversationId, Conversation body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsCall");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationsCall");

            var localVarPath = "/api/v2/conversations/calls/{conversationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCall: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCall: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarHeaders,
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant request</param>
        /// <returns></returns>
        public void PatchConversationsCallParticipant (string conversationId, string participantId, MediaParticipantRequest body)
        {
             PatchConversationsCallParticipantWithHttpInfo(conversationId, participantId, body);
        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchConversationsCallParticipantWithHttpInfo (string conversationId, string participantId, MediaParticipantRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsCallParticipant");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationsCallParticipant");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationsCallParticipant");

            var localVarPath = "/api/v2/conversations/calls/{conversationId}/participants/{participantId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCallParticipant: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCallParticipant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant request</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchConversationsCallParticipantAsync (string conversationId, string participantId, MediaParticipantRequest body)
        {
             await PatchConversationsCallParticipantAsyncWithHttpInfo(conversationId, participantId, body);

        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant request</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchConversationsCallParticipantAsyncWithHttpInfo (string conversationId, string participantId, MediaParticipantRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsCallParticipant");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationsCallParticipant");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationsCallParticipant");

            var localVarPath = "/api/v2/conversations/calls/{conversationId}/participants/{participantId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCallParticipant: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCallParticipant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns></returns>
        public void PatchConversationsCallParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body)
        {
             PatchConversationsCallParticipantAttributesWithHttpInfo(conversationId, participantId, body);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchConversationsCallParticipantAttributesWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsCallParticipantAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationsCallParticipantAttributes");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationsCallParticipantAttributes");

            var localVarPath = "/api/v2/conversations/calls/{conversationId}/participants/{participantId}/attributes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCallParticipantAttributes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCallParticipantAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchConversationsCallParticipantAttributesAsync (string conversationId, string participantId, ParticipantAttributes body)
        {
             await PatchConversationsCallParticipantAttributesAsyncWithHttpInfo(conversationId, participantId, body);

        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchConversationsCallParticipantAttributesAsyncWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsCallParticipantAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationsCallParticipantAttributes");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationsCallParticipantAttributes");

            var localVarPath = "/api/v2/conversations/calls/{conversationId}/participants/{participantId}/attributes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCallParticipantAttributes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCallParticipantAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Empty</returns>
        public Empty PatchConversationsCallParticipantCommunication (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)
        {
             ApiResponse<Empty> localVarResponse = PatchConversationsCallParticipantCommunicationWithHttpInfo(conversationId, participantId, communicationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>ApiResponse of Empty</returns>
        public ApiResponse< Empty > PatchConversationsCallParticipantCommunicationWithHttpInfo (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsCallParticipantCommunication");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationsCallParticipantCommunication");
            // verify the required parameter 'communicationId' is set
            if (communicationId == null)
                throw new ApiException(400, "Missing required parameter 'communicationId' when calling ConversationsApi->PatchConversationsCallParticipantCommunication");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationsCallParticipantCommunication");

            var localVarPath = "/api/v2/conversations/calls/{conversationId}/participants/{participantId}/communications/{communicationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (communicationId != null) localVarPathParams.Add("communicationId", Configuration.ApiClient.ParameterToString(communicationId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCallParticipantCommunication: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCallParticipantCommunication: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Empty>(localVarStatusCode,
                localVarHeaders,
                (Empty) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Empty)));
            
        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of Empty</returns>
        public async System.Threading.Tasks.Task<Empty> PatchConversationsCallParticipantCommunicationAsync (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)
        {
             ApiResponse<Empty> localVarResponse = await PatchConversationsCallParticipantCommunicationAsyncWithHttpInfo(conversationId, participantId, communicationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of ApiResponse (Empty)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Empty>> PatchConversationsCallParticipantCommunicationAsyncWithHttpInfo (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsCallParticipantCommunication");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationsCallParticipantCommunication");
            // verify the required parameter 'communicationId' is set
            if (communicationId == null)
                throw new ApiException(400, "Missing required parameter 'communicationId' when calling ConversationsApi->PatchConversationsCallParticipantCommunication");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationsCallParticipantCommunication");

            var localVarPath = "/api/v2/conversations/calls/{conversationId}/participants/{participantId}/communications/{communicationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (communicationId != null) localVarPathParams.Add("communicationId", Configuration.ApiClient.ParameterToString(communicationId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCallParticipantCommunication: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCallParticipantCommunication: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Empty>(localVarStatusCode,
                localVarHeaders,
                (Empty) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Empty)));
            
        }

        /// <summary>
        /// Change who can speak 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">new speak to</param>
        /// <returns>ConsultTransferResponse</returns>
        public ConsultTransferResponse PatchConversationsCallParticipantConsult (string conversationId, string participantId, ConsultTransferUpdate body)
        {
             ApiResponse<ConsultTransferResponse> localVarResponse = PatchConversationsCallParticipantConsultWithHttpInfo(conversationId, participantId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Change who can speak 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">new speak to</param>
        /// <returns>ApiResponse of ConsultTransferResponse</returns>
        public ApiResponse< ConsultTransferResponse > PatchConversationsCallParticipantConsultWithHttpInfo (string conversationId, string participantId, ConsultTransferUpdate body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsCallParticipantConsult");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationsCallParticipantConsult");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationsCallParticipantConsult");

            var localVarPath = "/api/v2/conversations/calls/{conversationId}/participants/{participantId}/consult";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCallParticipantConsult: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCallParticipantConsult: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConsultTransferResponse>(localVarStatusCode,
                localVarHeaders,
                (ConsultTransferResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsultTransferResponse)));
            
        }

        /// <summary>
        /// Change who can speak 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">new speak to</param>
        /// <returns>Task of ConsultTransferResponse</returns>
        public async System.Threading.Tasks.Task<ConsultTransferResponse> PatchConversationsCallParticipantConsultAsync (string conversationId, string participantId, ConsultTransferUpdate body)
        {
             ApiResponse<ConsultTransferResponse> localVarResponse = await PatchConversationsCallParticipantConsultAsyncWithHttpInfo(conversationId, participantId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Change who can speak 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">new speak to</param>
        /// <returns>Task of ApiResponse (ConsultTransferResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConsultTransferResponse>> PatchConversationsCallParticipantConsultAsyncWithHttpInfo (string conversationId, string participantId, ConsultTransferUpdate body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsCallParticipantConsult");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationsCallParticipantConsult");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationsCallParticipantConsult");

            var localVarPath = "/api/v2/conversations/calls/{conversationId}/participants/{participantId}/consult";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCallParticipantConsult: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCallParticipantConsult: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConsultTransferResponse>(localVarStatusCode,
                localVarHeaders,
                (ConsultTransferResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsultTransferResponse)));
            
        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        public Conversation PatchConversationsCallback (string conversationId, Conversation body)
        {
             ApiResponse<Conversation> localVarResponse = PatchConversationsCallbackWithHttpInfo(conversationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        public ApiResponse< Conversation > PatchConversationsCallbackWithHttpInfo (string conversationId, Conversation body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsCallback");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationsCallback");

            var localVarPath = "/api/v2/conversations/callbacks/{conversationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCallback: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCallback: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarHeaders,
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        public async System.Threading.Tasks.Task<Conversation> PatchConversationsCallbackAsync (string conversationId, Conversation body)
        {
             ApiResponse<Conversation> localVarResponse = await PatchConversationsCallbackAsyncWithHttpInfo(conversationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conversation>> PatchConversationsCallbackAsyncWithHttpInfo (string conversationId, Conversation body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsCallback");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationsCallback");

            var localVarPath = "/api/v2/conversations/callbacks/{conversationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCallback: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCallback: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarHeaders,
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant</param>
        /// <returns></returns>
        public void PatchConversationsCallbackParticipant (string conversationId, string participantId, MediaParticipantRequest body)
        {
             PatchConversationsCallbackParticipantWithHttpInfo(conversationId, participantId, body);
        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchConversationsCallbackParticipantWithHttpInfo (string conversationId, string participantId, MediaParticipantRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsCallbackParticipant");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationsCallbackParticipant");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationsCallbackParticipant");

            var localVarPath = "/api/v2/conversations/callbacks/{conversationId}/participants/{participantId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCallbackParticipant: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCallbackParticipant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchConversationsCallbackParticipantAsync (string conversationId, string participantId, MediaParticipantRequest body)
        {
             await PatchConversationsCallbackParticipantAsyncWithHttpInfo(conversationId, participantId, body);

        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchConversationsCallbackParticipantAsyncWithHttpInfo (string conversationId, string participantId, MediaParticipantRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsCallbackParticipant");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationsCallbackParticipant");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationsCallbackParticipant");

            var localVarPath = "/api/v2/conversations/callbacks/{conversationId}/participants/{participantId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCallbackParticipant: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCallbackParticipant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Attributes</param>
        /// <returns></returns>
        public void PatchConversationsCallbackParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body)
        {
             PatchConversationsCallbackParticipantAttributesWithHttpInfo(conversationId, participantId, body);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Attributes</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchConversationsCallbackParticipantAttributesWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsCallbackParticipantAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationsCallbackParticipantAttributes");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationsCallbackParticipantAttributes");

            var localVarPath = "/api/v2/conversations/callbacks/{conversationId}/participants/{participantId}/attributes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCallbackParticipantAttributes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCallbackParticipantAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Attributes</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchConversationsCallbackParticipantAttributesAsync (string conversationId, string participantId, ParticipantAttributes body)
        {
             await PatchConversationsCallbackParticipantAttributesAsyncWithHttpInfo(conversationId, participantId, body);

        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Attributes</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchConversationsCallbackParticipantAttributesAsyncWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsCallbackParticipantAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationsCallbackParticipantAttributes");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationsCallbackParticipantAttributes");

            var localVarPath = "/api/v2/conversations/callbacks/{conversationId}/participants/{participantId}/attributes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCallbackParticipantAttributes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCallbackParticipantAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Empty</returns>
        public Empty PatchConversationsCallbackParticipantCommunication (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)
        {
             ApiResponse<Empty> localVarResponse = PatchConversationsCallbackParticipantCommunicationWithHttpInfo(conversationId, participantId, communicationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>ApiResponse of Empty</returns>
        public ApiResponse< Empty > PatchConversationsCallbackParticipantCommunicationWithHttpInfo (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsCallbackParticipantCommunication");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationsCallbackParticipantCommunication");
            // verify the required parameter 'communicationId' is set
            if (communicationId == null)
                throw new ApiException(400, "Missing required parameter 'communicationId' when calling ConversationsApi->PatchConversationsCallbackParticipantCommunication");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationsCallbackParticipantCommunication");

            var localVarPath = "/api/v2/conversations/callbacks/{conversationId}/participants/{participantId}/communications/{communicationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (communicationId != null) localVarPathParams.Add("communicationId", Configuration.ApiClient.ParameterToString(communicationId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCallbackParticipantCommunication: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCallbackParticipantCommunication: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Empty>(localVarStatusCode,
                localVarHeaders,
                (Empty) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Empty)));
            
        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of Empty</returns>
        public async System.Threading.Tasks.Task<Empty> PatchConversationsCallbackParticipantCommunicationAsync (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)
        {
             ApiResponse<Empty> localVarResponse = await PatchConversationsCallbackParticipantCommunicationAsyncWithHttpInfo(conversationId, participantId, communicationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of ApiResponse (Empty)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Empty>> PatchConversationsCallbackParticipantCommunicationAsyncWithHttpInfo (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsCallbackParticipantCommunication");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationsCallbackParticipantCommunication");
            // verify the required parameter 'communicationId' is set
            if (communicationId == null)
                throw new ApiException(400, "Missing required parameter 'communicationId' when calling ConversationsApi->PatchConversationsCallbackParticipantCommunication");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationsCallbackParticipantCommunication");

            var localVarPath = "/api/v2/conversations/callbacks/{conversationId}/participants/{participantId}/communications/{communicationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (communicationId != null) localVarPathParams.Add("communicationId", Configuration.ApiClient.ParameterToString(communicationId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCallbackParticipantCommunication: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCallbackParticipantCommunication: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Empty>(localVarStatusCode,
                localVarHeaders,
                (Empty) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Empty)));
            
        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        public Conversation PatchConversationsChat (string conversationId, Conversation body)
        {
             ApiResponse<Conversation> localVarResponse = PatchConversationsChatWithHttpInfo(conversationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        public ApiResponse< Conversation > PatchConversationsChatWithHttpInfo (string conversationId, Conversation body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsChat");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationsChat");

            var localVarPath = "/api/v2/conversations/chats/{conversationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsChat: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsChat: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarHeaders,
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        public async System.Threading.Tasks.Task<Conversation> PatchConversationsChatAsync (string conversationId, Conversation body)
        {
             ApiResponse<Conversation> localVarResponse = await PatchConversationsChatAsyncWithHttpInfo(conversationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conversation>> PatchConversationsChatAsyncWithHttpInfo (string conversationId, Conversation body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsChat");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationsChat");

            var localVarPath = "/api/v2/conversations/chats/{conversationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsChat: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsChat: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarHeaders,
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Update request</param>
        /// <returns></returns>
        public void PatchConversationsChatParticipant (string conversationId, string participantId, MediaParticipantRequest body)
        {
             PatchConversationsChatParticipantWithHttpInfo(conversationId, participantId, body);
        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Update request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchConversationsChatParticipantWithHttpInfo (string conversationId, string participantId, MediaParticipantRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsChatParticipant");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationsChatParticipant");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationsChatParticipant");

            var localVarPath = "/api/v2/conversations/chats/{conversationId}/participants/{participantId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsChatParticipant: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsChatParticipant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Update request</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchConversationsChatParticipantAsync (string conversationId, string participantId, MediaParticipantRequest body)
        {
             await PatchConversationsChatParticipantAsyncWithHttpInfo(conversationId, participantId, body);

        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Update request</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchConversationsChatParticipantAsyncWithHttpInfo (string conversationId, string participantId, MediaParticipantRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsChatParticipant");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationsChatParticipant");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationsChatParticipant");

            var localVarPath = "/api/v2/conversations/chats/{conversationId}/participants/{participantId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsChatParticipant: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsChatParticipant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns></returns>
        public void PatchConversationsChatParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body)
        {
             PatchConversationsChatParticipantAttributesWithHttpInfo(conversationId, participantId, body);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchConversationsChatParticipantAttributesWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsChatParticipantAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationsChatParticipantAttributes");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationsChatParticipantAttributes");

            var localVarPath = "/api/v2/conversations/chats/{conversationId}/participants/{participantId}/attributes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsChatParticipantAttributes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsChatParticipantAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchConversationsChatParticipantAttributesAsync (string conversationId, string participantId, ParticipantAttributes body)
        {
             await PatchConversationsChatParticipantAttributesAsyncWithHttpInfo(conversationId, participantId, body);

        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchConversationsChatParticipantAttributesAsyncWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsChatParticipantAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationsChatParticipantAttributes");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationsChatParticipantAttributes");

            var localVarPath = "/api/v2/conversations/chats/{conversationId}/participants/{participantId}/attributes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsChatParticipantAttributes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsChatParticipantAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Empty</returns>
        public Empty PatchConversationsChatParticipantCommunication (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)
        {
             ApiResponse<Empty> localVarResponse = PatchConversationsChatParticipantCommunicationWithHttpInfo(conversationId, participantId, communicationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>ApiResponse of Empty</returns>
        public ApiResponse< Empty > PatchConversationsChatParticipantCommunicationWithHttpInfo (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsChatParticipantCommunication");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationsChatParticipantCommunication");
            // verify the required parameter 'communicationId' is set
            if (communicationId == null)
                throw new ApiException(400, "Missing required parameter 'communicationId' when calling ConversationsApi->PatchConversationsChatParticipantCommunication");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationsChatParticipantCommunication");

            var localVarPath = "/api/v2/conversations/chats/{conversationId}/participants/{participantId}/communications/{communicationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (communicationId != null) localVarPathParams.Add("communicationId", Configuration.ApiClient.ParameterToString(communicationId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsChatParticipantCommunication: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsChatParticipantCommunication: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Empty>(localVarStatusCode,
                localVarHeaders,
                (Empty) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Empty)));
            
        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of Empty</returns>
        public async System.Threading.Tasks.Task<Empty> PatchConversationsChatParticipantCommunicationAsync (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)
        {
             ApiResponse<Empty> localVarResponse = await PatchConversationsChatParticipantCommunicationAsyncWithHttpInfo(conversationId, participantId, communicationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of ApiResponse (Empty)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Empty>> PatchConversationsChatParticipantCommunicationAsyncWithHttpInfo (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsChatParticipantCommunication");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationsChatParticipantCommunication");
            // verify the required parameter 'communicationId' is set
            if (communicationId == null)
                throw new ApiException(400, "Missing required parameter 'communicationId' when calling ConversationsApi->PatchConversationsChatParticipantCommunication");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationsChatParticipantCommunication");

            var localVarPath = "/api/v2/conversations/chats/{conversationId}/participants/{participantId}/communications/{communicationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (communicationId != null) localVarPathParams.Add("communicationId", Configuration.ApiClient.ParameterToString(communicationId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsChatParticipantCommunication: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsChatParticipantCommunication: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Empty>(localVarStatusCode,
                localVarHeaders,
                (Empty) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Empty)));
            
        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        public Conversation PatchConversationsCobrowsesession (string conversationId, Conversation body)
        {
             ApiResponse<Conversation> localVarResponse = PatchConversationsCobrowsesessionWithHttpInfo(conversationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        public ApiResponse< Conversation > PatchConversationsCobrowsesessionWithHttpInfo (string conversationId, Conversation body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsCobrowsesession");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationsCobrowsesession");

            var localVarPath = "/api/v2/conversations/cobrowsesessions/{conversationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCobrowsesession: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCobrowsesession: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarHeaders,
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        public async System.Threading.Tasks.Task<Conversation> PatchConversationsCobrowsesessionAsync (string conversationId, Conversation body)
        {
             ApiResponse<Conversation> localVarResponse = await PatchConversationsCobrowsesessionAsyncWithHttpInfo(conversationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conversation>> PatchConversationsCobrowsesessionAsyncWithHttpInfo (string conversationId, Conversation body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsCobrowsesession");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationsCobrowsesession");

            var localVarPath = "/api/v2/conversations/cobrowsesessions/{conversationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCobrowsesession: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCobrowsesession: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarHeaders,
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        public void PatchConversationsCobrowsesessionParticipant (string conversationId, string participantId, MediaParticipantRequest body = null)
        {
             PatchConversationsCobrowsesessionParticipantWithHttpInfo(conversationId, participantId, body);
        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchConversationsCobrowsesessionParticipantWithHttpInfo (string conversationId, string participantId, MediaParticipantRequest body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsCobrowsesessionParticipant");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationsCobrowsesessionParticipant");

            var localVarPath = "/api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCobrowsesessionParticipant: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCobrowsesessionParticipant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchConversationsCobrowsesessionParticipantAsync (string conversationId, string participantId, MediaParticipantRequest body = null)
        {
             await PatchConversationsCobrowsesessionParticipantAsyncWithHttpInfo(conversationId, participantId, body);

        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchConversationsCobrowsesessionParticipantAsyncWithHttpInfo (string conversationId, string participantId, MediaParticipantRequest body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsCobrowsesessionParticipant");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationsCobrowsesessionParticipant");

            var localVarPath = "/api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCobrowsesessionParticipant: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCobrowsesessionParticipant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        public void PatchConversationsCobrowsesessionParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body = null)
        {
             PatchConversationsCobrowsesessionParticipantAttributesWithHttpInfo(conversationId, participantId, body);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchConversationsCobrowsesessionParticipantAttributesWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsCobrowsesessionParticipantAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationsCobrowsesessionParticipantAttributes");

            var localVarPath = "/api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId}/attributes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCobrowsesessionParticipantAttributes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCobrowsesessionParticipantAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchConversationsCobrowsesessionParticipantAttributesAsync (string conversationId, string participantId, ParticipantAttributes body = null)
        {
             await PatchConversationsCobrowsesessionParticipantAttributesAsyncWithHttpInfo(conversationId, participantId, body);

        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchConversationsCobrowsesessionParticipantAttributesAsyncWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsCobrowsesessionParticipantAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationsCobrowsesessionParticipantAttributes");

            var localVarPath = "/api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId}/attributes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCobrowsesessionParticipantAttributes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCobrowsesessionParticipantAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Empty</returns>
        public Empty PatchConversationsCobrowsesessionParticipantCommunication (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)
        {
             ApiResponse<Empty> localVarResponse = PatchConversationsCobrowsesessionParticipantCommunicationWithHttpInfo(conversationId, participantId, communicationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>ApiResponse of Empty</returns>
        public ApiResponse< Empty > PatchConversationsCobrowsesessionParticipantCommunicationWithHttpInfo (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsCobrowsesessionParticipantCommunication");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationsCobrowsesessionParticipantCommunication");
            // verify the required parameter 'communicationId' is set
            if (communicationId == null)
                throw new ApiException(400, "Missing required parameter 'communicationId' when calling ConversationsApi->PatchConversationsCobrowsesessionParticipantCommunication");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationsCobrowsesessionParticipantCommunication");

            var localVarPath = "/api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId}/communications/{communicationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (communicationId != null) localVarPathParams.Add("communicationId", Configuration.ApiClient.ParameterToString(communicationId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCobrowsesessionParticipantCommunication: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCobrowsesessionParticipantCommunication: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Empty>(localVarStatusCode,
                localVarHeaders,
                (Empty) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Empty)));
            
        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of Empty</returns>
        public async System.Threading.Tasks.Task<Empty> PatchConversationsCobrowsesessionParticipantCommunicationAsync (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)
        {
             ApiResponse<Empty> localVarResponse = await PatchConversationsCobrowsesessionParticipantCommunicationAsyncWithHttpInfo(conversationId, participantId, communicationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of ApiResponse (Empty)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Empty>> PatchConversationsCobrowsesessionParticipantCommunicationAsyncWithHttpInfo (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsCobrowsesessionParticipantCommunication");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationsCobrowsesessionParticipantCommunication");
            // verify the required parameter 'communicationId' is set
            if (communicationId == null)
                throw new ApiException(400, "Missing required parameter 'communicationId' when calling ConversationsApi->PatchConversationsCobrowsesessionParticipantCommunication");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationsCobrowsesessionParticipantCommunication");

            var localVarPath = "/api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId}/communications/{communicationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (communicationId != null) localVarPathParams.Add("communicationId", Configuration.ApiClient.ParameterToString(communicationId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCobrowsesessionParticipantCommunication: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsCobrowsesessionParticipantCommunication: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Empty>(localVarStatusCode,
                localVarHeaders,
                (Empty) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Empty)));
            
        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        public Conversation PatchConversationsEmail (string conversationId, Conversation body)
        {
             ApiResponse<Conversation> localVarResponse = PatchConversationsEmailWithHttpInfo(conversationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        public ApiResponse< Conversation > PatchConversationsEmailWithHttpInfo (string conversationId, Conversation body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsEmail");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationsEmail");

            var localVarPath = "/api/v2/conversations/emails/{conversationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsEmail: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsEmail: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarHeaders,
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        public async System.Threading.Tasks.Task<Conversation> PatchConversationsEmailAsync (string conversationId, Conversation body)
        {
             ApiResponse<Conversation> localVarResponse = await PatchConversationsEmailAsyncWithHttpInfo(conversationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conversation>> PatchConversationsEmailAsyncWithHttpInfo (string conversationId, Conversation body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsEmail");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationsEmail");

            var localVarPath = "/api/v2/conversations/emails/{conversationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsEmail: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsEmail: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarHeaders,
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Update request</param>
        /// <returns></returns>
        public void PatchConversationsEmailParticipant (string conversationId, string participantId, MediaParticipantRequest body)
        {
             PatchConversationsEmailParticipantWithHttpInfo(conversationId, participantId, body);
        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Update request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchConversationsEmailParticipantWithHttpInfo (string conversationId, string participantId, MediaParticipantRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsEmailParticipant");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationsEmailParticipant");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationsEmailParticipant");

            var localVarPath = "/api/v2/conversations/emails/{conversationId}/participants/{participantId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsEmailParticipant: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsEmailParticipant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Update request</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchConversationsEmailParticipantAsync (string conversationId, string participantId, MediaParticipantRequest body)
        {
             await PatchConversationsEmailParticipantAsyncWithHttpInfo(conversationId, participantId, body);

        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Update request</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchConversationsEmailParticipantAsyncWithHttpInfo (string conversationId, string participantId, MediaParticipantRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsEmailParticipant");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationsEmailParticipant");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationsEmailParticipant");

            var localVarPath = "/api/v2/conversations/emails/{conversationId}/participants/{participantId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsEmailParticipant: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsEmailParticipant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns></returns>
        public void PatchConversationsEmailParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body)
        {
             PatchConversationsEmailParticipantAttributesWithHttpInfo(conversationId, participantId, body);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchConversationsEmailParticipantAttributesWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsEmailParticipantAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationsEmailParticipantAttributes");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationsEmailParticipantAttributes");

            var localVarPath = "/api/v2/conversations/emails/{conversationId}/participants/{participantId}/attributes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsEmailParticipantAttributes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsEmailParticipantAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchConversationsEmailParticipantAttributesAsync (string conversationId, string participantId, ParticipantAttributes body)
        {
             await PatchConversationsEmailParticipantAttributesAsyncWithHttpInfo(conversationId, participantId, body);

        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchConversationsEmailParticipantAttributesAsyncWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsEmailParticipantAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationsEmailParticipantAttributes");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationsEmailParticipantAttributes");

            var localVarPath = "/api/v2/conversations/emails/{conversationId}/participants/{participantId}/attributes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsEmailParticipantAttributes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsEmailParticipantAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Empty</returns>
        public Empty PatchConversationsEmailParticipantCommunication (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)
        {
             ApiResponse<Empty> localVarResponse = PatchConversationsEmailParticipantCommunicationWithHttpInfo(conversationId, participantId, communicationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>ApiResponse of Empty</returns>
        public ApiResponse< Empty > PatchConversationsEmailParticipantCommunicationWithHttpInfo (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsEmailParticipantCommunication");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationsEmailParticipantCommunication");
            // verify the required parameter 'communicationId' is set
            if (communicationId == null)
                throw new ApiException(400, "Missing required parameter 'communicationId' when calling ConversationsApi->PatchConversationsEmailParticipantCommunication");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationsEmailParticipantCommunication");

            var localVarPath = "/api/v2/conversations/emails/{conversationId}/participants/{participantId}/communications/{communicationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (communicationId != null) localVarPathParams.Add("communicationId", Configuration.ApiClient.ParameterToString(communicationId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsEmailParticipantCommunication: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsEmailParticipantCommunication: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Empty>(localVarStatusCode,
                localVarHeaders,
                (Empty) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Empty)));
            
        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of Empty</returns>
        public async System.Threading.Tasks.Task<Empty> PatchConversationsEmailParticipantCommunicationAsync (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)
        {
             ApiResponse<Empty> localVarResponse = await PatchConversationsEmailParticipantCommunicationAsyncWithHttpInfo(conversationId, participantId, communicationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of ApiResponse (Empty)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Empty>> PatchConversationsEmailParticipantCommunicationAsyncWithHttpInfo (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationsEmailParticipantCommunication");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationsEmailParticipantCommunication");
            // verify the required parameter 'communicationId' is set
            if (communicationId == null)
                throw new ApiException(400, "Missing required parameter 'communicationId' when calling ConversationsApi->PatchConversationsEmailParticipantCommunication");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationsEmailParticipantCommunication");

            var localVarPath = "/api/v2/conversations/emails/{conversationId}/participants/{participantId}/communications/{communicationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (communicationId != null) localVarPathParams.Add("communicationId", Configuration.ApiClient.ParameterToString(communicationId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsEmailParticipantCommunication: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationsEmailParticipantCommunication: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Empty>(localVarStatusCode,
                localVarHeaders,
                (Empty) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Empty)));
            
        }

        /// <summary>
        /// Index conversation properties 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">request</param>
        /// <returns>PropertyIndexRequest</returns>
        public PropertyIndexRequest PostAnalyticsConversationDetailsProperties (string conversationId, PropertyIndexRequest body)
        {
             ApiResponse<PropertyIndexRequest> localVarResponse = PostAnalyticsConversationDetailsPropertiesWithHttpInfo(conversationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Index conversation properties 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">request</param>
        /// <returns>ApiResponse of PropertyIndexRequest</returns>
        public ApiResponse< PropertyIndexRequest > PostAnalyticsConversationDetailsPropertiesWithHttpInfo (string conversationId, PropertyIndexRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostAnalyticsConversationDetailsProperties");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostAnalyticsConversationDetailsProperties");

            var localVarPath = "/api/v2/analytics/conversations/{conversationId}/details/properties";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsConversationDetailsProperties: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsConversationDetailsProperties: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PropertyIndexRequest>(localVarStatusCode,
                localVarHeaders,
                (PropertyIndexRequest) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PropertyIndexRequest)));
            
        }

        /// <summary>
        /// Index conversation properties 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">request</param>
        /// <returns>Task of PropertyIndexRequest</returns>
        public async System.Threading.Tasks.Task<PropertyIndexRequest> PostAnalyticsConversationDetailsPropertiesAsync (string conversationId, PropertyIndexRequest body)
        {
             ApiResponse<PropertyIndexRequest> localVarResponse = await PostAnalyticsConversationDetailsPropertiesAsyncWithHttpInfo(conversationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Index conversation properties 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">request</param>
        /// <returns>Task of ApiResponse (PropertyIndexRequest)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PropertyIndexRequest>> PostAnalyticsConversationDetailsPropertiesAsyncWithHttpInfo (string conversationId, PropertyIndexRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostAnalyticsConversationDetailsProperties");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostAnalyticsConversationDetailsProperties");

            var localVarPath = "/api/v2/analytics/conversations/{conversationId}/details/properties";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsConversationDetailsProperties: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsConversationDetailsProperties: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PropertyIndexRequest>(localVarStatusCode,
                localVarHeaders,
                (PropertyIndexRequest) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PropertyIndexRequest)));
            
        }

        /// <summary>
        /// Query for conversation aggregates 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>AggregateQueryResponse</returns>
        public AggregateQueryResponse PostAnalyticsConversationsAggregatesQuery (AggregationQuery body)
        {
             ApiResponse<AggregateQueryResponse> localVarResponse = PostAnalyticsConversationsAggregatesQueryWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query for conversation aggregates 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of AggregateQueryResponse</returns>
        public ApiResponse< AggregateQueryResponse > PostAnalyticsConversationsAggregatesQueryWithHttpInfo (AggregationQuery body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostAnalyticsConversationsAggregatesQuery");

            var localVarPath = "/api/v2/analytics/conversations/aggregates/query";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsConversationsAggregatesQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsConversationsAggregatesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AggregateQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (AggregateQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AggregateQueryResponse)));
            
        }

        /// <summary>
        /// Query for conversation aggregates 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of AggregateQueryResponse</returns>
        public async System.Threading.Tasks.Task<AggregateQueryResponse> PostAnalyticsConversationsAggregatesQueryAsync (AggregationQuery body)
        {
             ApiResponse<AggregateQueryResponse> localVarResponse = await PostAnalyticsConversationsAggregatesQueryAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query for conversation aggregates 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (AggregateQueryResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AggregateQueryResponse>> PostAnalyticsConversationsAggregatesQueryAsyncWithHttpInfo (AggregationQuery body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostAnalyticsConversationsAggregatesQuery");

            var localVarPath = "/api/v2/analytics/conversations/aggregates/query";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsConversationsAggregatesQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsConversationsAggregatesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AggregateQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (AggregateQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AggregateQueryResponse)));
            
        }

        /// <summary>
        /// Query for conversation details 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>AnalyticsConversationQueryResponse</returns>
        public AnalyticsConversationQueryResponse PostAnalyticsConversationsDetailsQuery (ConversationQuery body)
        {
             ApiResponse<AnalyticsConversationQueryResponse> localVarResponse = PostAnalyticsConversationsDetailsQueryWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query for conversation details 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of AnalyticsConversationQueryResponse</returns>
        public ApiResponse< AnalyticsConversationQueryResponse > PostAnalyticsConversationsDetailsQueryWithHttpInfo (ConversationQuery body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostAnalyticsConversationsDetailsQuery");

            var localVarPath = "/api/v2/analytics/conversations/details/query";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsConversationsDetailsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsConversationsDetailsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AnalyticsConversationQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (AnalyticsConversationQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AnalyticsConversationQueryResponse)));
            
        }

        /// <summary>
        /// Query for conversation details 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of AnalyticsConversationQueryResponse</returns>
        public async System.Threading.Tasks.Task<AnalyticsConversationQueryResponse> PostAnalyticsConversationsDetailsQueryAsync (ConversationQuery body)
        {
             ApiResponse<AnalyticsConversationQueryResponse> localVarResponse = await PostAnalyticsConversationsDetailsQueryAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query for conversation details 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (AnalyticsConversationQueryResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AnalyticsConversationQueryResponse>> PostAnalyticsConversationsDetailsQueryAsyncWithHttpInfo (ConversationQuery body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostAnalyticsConversationsDetailsQuery");

            var localVarPath = "/api/v2/analytics/conversations/details/query";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsConversationsDetailsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsConversationsDetailsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AnalyticsConversationQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (AnalyticsConversationQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AnalyticsConversationQueryResponse)));
            
        }

        /// <summary>
        /// Create a new callback for the specified participant on the conversation. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        public void PostConversationParticipantCallbacks (string conversationId, string participantId, CreateCallbackCommand body = null)
        {
             PostConversationParticipantCallbacksWithHttpInfo(conversationId, participantId, body);
        }

        /// <summary>
        /// Create a new callback for the specified participant on the conversation. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostConversationParticipantCallbacksWithHttpInfo (string conversationId, string participantId, CreateCallbackCommand body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationParticipantCallbacks");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostConversationParticipantCallbacks");

            var localVarPath = "/api/v2/conversations/{conversationId}/participants/{participantId}/callbacks";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationParticipantCallbacks: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationParticipantCallbacks: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Create a new callback for the specified participant on the conversation. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostConversationParticipantCallbacksAsync (string conversationId, string participantId, CreateCallbackCommand body = null)
        {
             await PostConversationParticipantCallbacksAsyncWithHttpInfo(conversationId, participantId, body);

        }

        /// <summary>
        /// Create a new callback for the specified participant on the conversation. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostConversationParticipantCallbacksAsyncWithHttpInfo (string conversationId, string participantId, CreateCallbackCommand body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationParticipantCallbacks");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostConversationParticipantCallbacks");

            var localVarPath = "/api/v2/conversations/{conversationId}/participants/{participantId}/callbacks";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationParticipantCallbacks: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationParticipantCallbacks: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Transfer request</param>
        /// <returns></returns>
        public void PostConversationParticipantReplace (string conversationId, string participantId, TransferRequest body)
        {
             PostConversationParticipantReplaceWithHttpInfo(conversationId, participantId, body);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Transfer request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostConversationParticipantReplaceWithHttpInfo (string conversationId, string participantId, TransferRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationParticipantReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostConversationParticipantReplace");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationParticipantReplace");

            var localVarPath = "/api/v2/conversations/{conversationId}/participants/{participantId}/replace";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationParticipantReplace: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationParticipantReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostConversationParticipantReplaceAsync (string conversationId, string participantId, TransferRequest body)
        {
             await PostConversationParticipantReplaceAsyncWithHttpInfo(conversationId, participantId, body);

        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostConversationParticipantReplaceAsyncWithHttpInfo (string conversationId, string participantId, TransferRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationParticipantReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostConversationParticipantReplace");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationParticipantReplace");

            var localVarPath = "/api/v2/conversations/{conversationId}/participants/{participantId}/replace";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationParticipantReplace: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationParticipantReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Add a new call to a conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        public Conversation PostConversationsCall (string conversationId, CallCommand body)
        {
             ApiResponse<Conversation> localVarResponse = PostConversationsCallWithHttpInfo(conversationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add a new call to a conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        public ApiResponse< Conversation > PostConversationsCallWithHttpInfo (string conversationId, CallCommand body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationsCall");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationsCall");

            var localVarPath = "/api/v2/conversations/calls/{conversationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsCall: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsCall: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarHeaders,
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Add a new call to a conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        public async System.Threading.Tasks.Task<Conversation> PostConversationsCallAsync (string conversationId, CallCommand body)
        {
             ApiResponse<Conversation> localVarResponse = await PostConversationsCallAsyncWithHttpInfo(conversationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add a new call to a conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conversation>> PostConversationsCallAsyncWithHttpInfo (string conversationId, CallCommand body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationsCall");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationsCall");

            var localVarPath = "/api/v2/conversations/calls/{conversationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsCall: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsCall: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarHeaders,
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Initiate and update consult transfer 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Destination address &amp; initial speak to</param>
        /// <returns>ConsultTransferResponse</returns>
        public ConsultTransferResponse PostConversationsCallParticipantConsult (string conversationId, string participantId, ConsultTransfer body)
        {
             ApiResponse<ConsultTransferResponse> localVarResponse = PostConversationsCallParticipantConsultWithHttpInfo(conversationId, participantId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Initiate and update consult transfer 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Destination address &amp; initial speak to</param>
        /// <returns>ApiResponse of ConsultTransferResponse</returns>
        public ApiResponse< ConsultTransferResponse > PostConversationsCallParticipantConsultWithHttpInfo (string conversationId, string participantId, ConsultTransfer body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationsCallParticipantConsult");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostConversationsCallParticipantConsult");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationsCallParticipantConsult");

            var localVarPath = "/api/v2/conversations/calls/{conversationId}/participants/{participantId}/consult";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsCallParticipantConsult: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsCallParticipantConsult: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConsultTransferResponse>(localVarStatusCode,
                localVarHeaders,
                (ConsultTransferResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsultTransferResponse)));
            
        }

        /// <summary>
        /// Initiate and update consult transfer 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Destination address &amp; initial speak to</param>
        /// <returns>Task of ConsultTransferResponse</returns>
        public async System.Threading.Tasks.Task<ConsultTransferResponse> PostConversationsCallParticipantConsultAsync (string conversationId, string participantId, ConsultTransfer body)
        {
             ApiResponse<ConsultTransferResponse> localVarResponse = await PostConversationsCallParticipantConsultAsyncWithHttpInfo(conversationId, participantId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Initiate and update consult transfer 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Destination address &amp; initial speak to</param>
        /// <returns>Task of ApiResponse (ConsultTransferResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConsultTransferResponse>> PostConversationsCallParticipantConsultAsyncWithHttpInfo (string conversationId, string participantId, ConsultTransfer body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationsCallParticipantConsult");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostConversationsCallParticipantConsult");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationsCallParticipantConsult");

            var localVarPath = "/api/v2/conversations/calls/{conversationId}/participants/{participantId}/consult";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsCallParticipantConsult: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsCallParticipantConsult: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConsultTransferResponse>(localVarStatusCode,
                localVarHeaders,
                (ConsultTransferResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsultTransferResponse)));
            
        }

        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns></returns>
        public void PostConversationsCallParticipantMonitor (string conversationId, string participantId)
        {
             PostConversationsCallParticipantMonitorWithHttpInfo(conversationId, participantId);
        }

        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostConversationsCallParticipantMonitorWithHttpInfo (string conversationId, string participantId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationsCallParticipantMonitor");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostConversationsCallParticipantMonitor");

            var localVarPath = "/api/v2/conversations/calls/{conversationId}/participants/{participantId}/monitor";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsCallParticipantMonitor: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsCallParticipantMonitor: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostConversationsCallParticipantMonitorAsync (string conversationId, string participantId)
        {
             await PostConversationsCallParticipantMonitorAsyncWithHttpInfo(conversationId, participantId);

        }

        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostConversationsCallParticipantMonitorAsyncWithHttpInfo (string conversationId, string participantId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationsCallParticipantMonitor");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostConversationsCallParticipantMonitor");

            var localVarPath = "/api/v2/conversations/calls/{conversationId}/participants/{participantId}/monitor";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsCallParticipantMonitor: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsCallParticipantMonitor: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns></returns>
        public void PostConversationsCallParticipantReplace (string conversationId, string participantId, TransferRequest body)
        {
             PostConversationsCallParticipantReplaceWithHttpInfo(conversationId, participantId, body);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostConversationsCallParticipantReplaceWithHttpInfo (string conversationId, string participantId, TransferRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationsCallParticipantReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostConversationsCallParticipantReplace");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationsCallParticipantReplace");

            var localVarPath = "/api/v2/conversations/calls/{conversationId}/participants/{participantId}/replace";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsCallParticipantReplace: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsCallParticipantReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostConversationsCallParticipantReplaceAsync (string conversationId, string participantId, TransferRequest body)
        {
             await PostConversationsCallParticipantReplaceAsyncWithHttpInfo(conversationId, participantId, body);

        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostConversationsCallParticipantReplaceAsyncWithHttpInfo (string conversationId, string participantId, TransferRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationsCallParticipantReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostConversationsCallParticipantReplace");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationsCallParticipantReplace");

            var localVarPath = "/api/v2/conversations/calls/{conversationId}/participants/{participantId}/replace";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsCallParticipantReplace: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsCallParticipantReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Add participants to a conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        public Conversation PostConversationsCallParticipants (string conversationId, Conversation body)
        {
             ApiResponse<Conversation> localVarResponse = PostConversationsCallParticipantsWithHttpInfo(conversationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add participants to a conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        public ApiResponse< Conversation > PostConversationsCallParticipantsWithHttpInfo (string conversationId, Conversation body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationsCallParticipants");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationsCallParticipants");

            var localVarPath = "/api/v2/conversations/calls/{conversationId}/participants";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsCallParticipants: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsCallParticipants: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarHeaders,
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Add participants to a conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        public async System.Threading.Tasks.Task<Conversation> PostConversationsCallParticipantsAsync (string conversationId, Conversation body)
        {
             ApiResponse<Conversation> localVarResponse = await PostConversationsCallParticipantsAsyncWithHttpInfo(conversationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add participants to a conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conversation>> PostConversationsCallParticipantsAsyncWithHttpInfo (string conversationId, Conversation body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationsCallParticipants");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationsCallParticipants");

            var localVarPath = "/api/v2/conversations/calls/{conversationId}/participants";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsCallParticipants: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsCallParticipants: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarHeaders,
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns></returns>
        public void PostConversationsCallbackParticipantReplace (string conversationId, string participantId, TransferRequest body)
        {
             PostConversationsCallbackParticipantReplaceWithHttpInfo(conversationId, participantId, body);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostConversationsCallbackParticipantReplaceWithHttpInfo (string conversationId, string participantId, TransferRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationsCallbackParticipantReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostConversationsCallbackParticipantReplace");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationsCallbackParticipantReplace");

            var localVarPath = "/api/v2/conversations/callbacks/{conversationId}/participants/{participantId}/replace";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsCallbackParticipantReplace: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsCallbackParticipantReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostConversationsCallbackParticipantReplaceAsync (string conversationId, string participantId, TransferRequest body)
        {
             await PostConversationsCallbackParticipantReplaceAsyncWithHttpInfo(conversationId, participantId, body);

        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostConversationsCallbackParticipantReplaceAsyncWithHttpInfo (string conversationId, string participantId, TransferRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationsCallbackParticipantReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostConversationsCallbackParticipantReplace");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationsCallbackParticipantReplace");

            var localVarPath = "/api/v2/conversations/callbacks/{conversationId}/participants/{participantId}/replace";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsCallbackParticipantReplace: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsCallbackParticipantReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Create a Callback 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Callback</param>
        /// <returns>CreateCallbackResponse</returns>
        public CreateCallbackResponse PostConversationsCallbacks (CreateCallbackCommand body)
        {
             ApiResponse<CreateCallbackResponse> localVarResponse = PostConversationsCallbacksWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Callback 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Callback</param>
        /// <returns>ApiResponse of CreateCallbackResponse</returns>
        public ApiResponse< CreateCallbackResponse > PostConversationsCallbacksWithHttpInfo (CreateCallbackCommand body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationsCallbacks");

            var localVarPath = "/api/v2/conversations/callbacks";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsCallbacks: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsCallbacks: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CreateCallbackResponse>(localVarStatusCode,
                localVarHeaders,
                (CreateCallbackResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateCallbackResponse)));
            
        }

        /// <summary>
        /// Create a Callback 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Callback</param>
        /// <returns>Task of CreateCallbackResponse</returns>
        public async System.Threading.Tasks.Task<CreateCallbackResponse> PostConversationsCallbacksAsync (CreateCallbackCommand body)
        {
             ApiResponse<CreateCallbackResponse> localVarResponse = await PostConversationsCallbacksAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a Callback 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Callback</param>
        /// <returns>Task of ApiResponse (CreateCallbackResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateCallbackResponse>> PostConversationsCallbacksAsyncWithHttpInfo (CreateCallbackCommand body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationsCallbacks");

            var localVarPath = "/api/v2/conversations/callbacks";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsCallbacks: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsCallbacks: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CreateCallbackResponse>(localVarStatusCode,
                localVarHeaders,
                (CreateCallbackResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateCallbackResponse)));
            
        }

        /// <summary>
        /// Create a call conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Call request</param>
        /// <returns>CreateCallResponse</returns>
        public CreateCallResponse PostConversationsCalls (CreateCallRequest body)
        {
             ApiResponse<CreateCallResponse> localVarResponse = PostConversationsCallsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a call conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Call request</param>
        /// <returns>ApiResponse of CreateCallResponse</returns>
        public ApiResponse< CreateCallResponse > PostConversationsCallsWithHttpInfo (CreateCallRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationsCalls");

            var localVarPath = "/api/v2/conversations/calls";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsCalls: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsCalls: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CreateCallResponse>(localVarStatusCode,
                localVarHeaders,
                (CreateCallResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateCallResponse)));
            
        }

        /// <summary>
        /// Create a call conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Call request</param>
        /// <returns>Task of CreateCallResponse</returns>
        public async System.Threading.Tasks.Task<CreateCallResponse> PostConversationsCallsAsync (CreateCallRequest body)
        {
             ApiResponse<CreateCallResponse> localVarResponse = await PostConversationsCallsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a call conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Call request</param>
        /// <returns>Task of ApiResponse (CreateCallResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateCallResponse>> PostConversationsCallsAsyncWithHttpInfo (CreateCallRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationsCalls");

            var localVarPath = "/api/v2/conversations/calls";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsCalls: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsCalls: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CreateCallResponse>(localVarStatusCode,
                localVarHeaders,
                (CreateCallResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateCallResponse)));
            
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns></returns>
        public void PostConversationsChatParticipantReplace (string conversationId, string participantId, TransferRequest body)
        {
             PostConversationsChatParticipantReplaceWithHttpInfo(conversationId, participantId, body);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostConversationsChatParticipantReplaceWithHttpInfo (string conversationId, string participantId, TransferRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationsChatParticipantReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostConversationsChatParticipantReplace");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationsChatParticipantReplace");

            var localVarPath = "/api/v2/conversations/chats/{conversationId}/participants/{participantId}/replace";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsChatParticipantReplace: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsChatParticipantReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostConversationsChatParticipantReplaceAsync (string conversationId, string participantId, TransferRequest body)
        {
             await PostConversationsChatParticipantReplaceAsyncWithHttpInfo(conversationId, participantId, body);

        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostConversationsChatParticipantReplaceAsyncWithHttpInfo (string conversationId, string participantId, TransferRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationsChatParticipantReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostConversationsChatParticipantReplace");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationsChatParticipantReplace");

            var localVarPath = "/api/v2/conversations/chats/{conversationId}/participants/{participantId}/replace";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsChatParticipantReplace: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsChatParticipantReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Create a web chat conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create web chat request</param>
        /// <returns>ChatConversation</returns>
        public ChatConversation PostConversationsChats (CreateWebChatRequest body)
        {
             ApiResponse<ChatConversation> localVarResponse = PostConversationsChatsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a web chat conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create web chat request</param>
        /// <returns>ApiResponse of ChatConversation</returns>
        public ApiResponse< ChatConversation > PostConversationsChatsWithHttpInfo (CreateWebChatRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationsChats");

            var localVarPath = "/api/v2/conversations/chats";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsChats: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsChats: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatConversation>(localVarStatusCode,
                localVarHeaders,
                (ChatConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatConversation)));
            
        }

        /// <summary>
        /// Create a web chat conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create web chat request</param>
        /// <returns>Task of ChatConversation</returns>
        public async System.Threading.Tasks.Task<ChatConversation> PostConversationsChatsAsync (CreateWebChatRequest body)
        {
             ApiResponse<ChatConversation> localVarResponse = await PostConversationsChatsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a web chat conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create web chat request</param>
        /// <returns>Task of ApiResponse (ChatConversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ChatConversation>> PostConversationsChatsAsyncWithHttpInfo (CreateWebChatRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationsChats");

            var localVarPath = "/api/v2/conversations/chats";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsChats: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsChats: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatConversation>(localVarStatusCode,
                localVarHeaders,
                (ChatConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatConversation)));
            
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        public void PostConversationsCobrowsesessionParticipantReplace (string conversationId, string participantId, TransferRequest body = null)
        {
             PostConversationsCobrowsesessionParticipantReplaceWithHttpInfo(conversationId, participantId, body);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostConversationsCobrowsesessionParticipantReplaceWithHttpInfo (string conversationId, string participantId, TransferRequest body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationsCobrowsesessionParticipantReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostConversationsCobrowsesessionParticipantReplace");

            var localVarPath = "/api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId}/replace";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsCobrowsesessionParticipantReplace: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsCobrowsesessionParticipantReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostConversationsCobrowsesessionParticipantReplaceAsync (string conversationId, string participantId, TransferRequest body = null)
        {
             await PostConversationsCobrowsesessionParticipantReplaceAsyncWithHttpInfo(conversationId, participantId, body);

        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostConversationsCobrowsesessionParticipantReplaceAsyncWithHttpInfo (string conversationId, string participantId, TransferRequest body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationsCobrowsesessionParticipantReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostConversationsCobrowsesessionParticipantReplace");

            var localVarPath = "/api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId}/replace";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsCobrowsesessionParticipantReplace: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsCobrowsesessionParticipantReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Send an email reply 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Reply</param>
        /// <returns>EmailMessage</returns>
        public EmailMessage PostConversationsEmailMessages (string conversationId, EmailMessage body)
        {
             ApiResponse<EmailMessage> localVarResponse = PostConversationsEmailMessagesWithHttpInfo(conversationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Send an email reply 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Reply</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        public ApiResponse< EmailMessage > PostConversationsEmailMessagesWithHttpInfo (string conversationId, EmailMessage body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationsEmailMessages");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationsEmailMessages");

            var localVarPath = "/api/v2/conversations/emails/{conversationId}/messages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsEmailMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsEmailMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarHeaders,
                (EmailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessage)));
            
        }

        /// <summary>
        /// Send an email reply 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Reply</param>
        /// <returns>Task of EmailMessage</returns>
        public async System.Threading.Tasks.Task<EmailMessage> PostConversationsEmailMessagesAsync (string conversationId, EmailMessage body)
        {
             ApiResponse<EmailMessage> localVarResponse = await PostConversationsEmailMessagesAsyncWithHttpInfo(conversationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Send an email reply 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Reply</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessage>> PostConversationsEmailMessagesAsyncWithHttpInfo (string conversationId, EmailMessage body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationsEmailMessages");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationsEmailMessages");

            var localVarPath = "/api/v2/conversations/emails/{conversationId}/messages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsEmailMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsEmailMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarHeaders,
                (EmailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessage)));
            
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns></returns>
        public void PostConversationsEmailParticipantReplace (string conversationId, string participantId, TransferRequest body)
        {
             PostConversationsEmailParticipantReplaceWithHttpInfo(conversationId, participantId, body);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostConversationsEmailParticipantReplaceWithHttpInfo (string conversationId, string participantId, TransferRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationsEmailParticipantReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostConversationsEmailParticipantReplace");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationsEmailParticipantReplace");

            var localVarPath = "/api/v2/conversations/emails/{conversationId}/participants/{participantId}/replace";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsEmailParticipantReplace: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsEmailParticipantReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostConversationsEmailParticipantReplaceAsync (string conversationId, string participantId, TransferRequest body)
        {
             await PostConversationsEmailParticipantReplaceAsyncWithHttpInfo(conversationId, participantId, body);

        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostConversationsEmailParticipantReplaceAsyncWithHttpInfo (string conversationId, string participantId, TransferRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationsEmailParticipantReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostConversationsEmailParticipantReplace");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationsEmailParticipantReplace");

            var localVarPath = "/api/v2/conversations/emails/{conversationId}/participants/{participantId}/replace";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsEmailParticipantReplace: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsEmailParticipantReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Create an email conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create email request</param>
        /// <returns>EmailConversation</returns>
        public EmailConversation PostConversationsEmails (CreateEmailRequest body)
        {
             ApiResponse<EmailConversation> localVarResponse = PostConversationsEmailsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an email conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create email request</param>
        /// <returns>ApiResponse of EmailConversation</returns>
        public ApiResponse< EmailConversation > PostConversationsEmailsWithHttpInfo (CreateEmailRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationsEmails");

            var localVarPath = "/api/v2/conversations/emails";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsEmails: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsEmails: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailConversation>(localVarStatusCode,
                localVarHeaders,
                (EmailConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailConversation)));
            
        }

        /// <summary>
        /// Create an email conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create email request</param>
        /// <returns>Task of EmailConversation</returns>
        public async System.Threading.Tasks.Task<EmailConversation> PostConversationsEmailsAsync (CreateEmailRequest body)
        {
             ApiResponse<EmailConversation> localVarResponse = await PostConversationsEmailsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an email conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create email request</param>
        /// <returns>Task of ApiResponse (EmailConversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailConversation>> PostConversationsEmailsAsyncWithHttpInfo (CreateEmailRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationsEmails");

            var localVarPath = "/api/v2/conversations/emails";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsEmails: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsEmails: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailConversation>(localVarStatusCode,
                localVarHeaders,
                (EmailConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailConversation)));
            
        }

        /// <summary>
        /// Create Fax Conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Fax</param>
        /// <returns>FaxSendResponse</returns>
        public FaxSendResponse PostConversationsFaxes (FaxSendRequest body)
        {
             ApiResponse<FaxSendResponse> localVarResponse = PostConversationsFaxesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Fax Conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Fax</param>
        /// <returns>ApiResponse of FaxSendResponse</returns>
        public ApiResponse< FaxSendResponse > PostConversationsFaxesWithHttpInfo (FaxSendRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationsFaxes");

            var localVarPath = "/api/v2/conversations/faxes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsFaxes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsFaxes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FaxSendResponse>(localVarStatusCode,
                localVarHeaders,
                (FaxSendResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaxSendResponse)));
            
        }

        /// <summary>
        /// Create Fax Conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Fax</param>
        /// <returns>Task of FaxSendResponse</returns>
        public async System.Threading.Tasks.Task<FaxSendResponse> PostConversationsFaxesAsync (FaxSendRequest body)
        {
             ApiResponse<FaxSendResponse> localVarResponse = await PostConversationsFaxesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create Fax Conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Fax</param>
        /// <returns>Task of ApiResponse (FaxSendResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FaxSendResponse>> PostConversationsFaxesAsyncWithHttpInfo (FaxSendRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationsFaxes");

            var localVarPath = "/api/v2/conversations/faxes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsFaxes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsFaxes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FaxSendResponse>(localVarStatusCode,
                localVarHeaders,
                (FaxSendResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaxSendResponse)));
            
        }

        /// <summary>
        /// Update conversation draft reply 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Draft</param>
        /// <returns>EmailMessage</returns>
        public EmailMessage PutConversationsEmailMessagesDraft (string conversationId, EmailMessage body)
        {
             ApiResponse<EmailMessage> localVarResponse = PutConversationsEmailMessagesDraftWithHttpInfo(conversationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update conversation draft reply 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Draft</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        public ApiResponse< EmailMessage > PutConversationsEmailMessagesDraftWithHttpInfo (string conversationId, EmailMessage body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PutConversationsEmailMessagesDraft");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PutConversationsEmailMessagesDraft");

            var localVarPath = "/api/v2/conversations/emails/{conversationId}/messages/draft";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutConversationsEmailMessagesDraft: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutConversationsEmailMessagesDraft: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarHeaders,
                (EmailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessage)));
            
        }

        /// <summary>
        /// Update conversation draft reply 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Draft</param>
        /// <returns>Task of EmailMessage</returns>
        public async System.Threading.Tasks.Task<EmailMessage> PutConversationsEmailMessagesDraftAsync (string conversationId, EmailMessage body)
        {
             ApiResponse<EmailMessage> localVarResponse = await PutConversationsEmailMessagesDraftAsyncWithHttpInfo(conversationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update conversation draft reply 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">Draft</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessage>> PutConversationsEmailMessagesDraftAsyncWithHttpInfo (string conversationId, EmailMessage body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PutConversationsEmailMessagesDraft");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PutConversationsEmailMessagesDraft");

            var localVarPath = "/api/v2/conversations/emails/{conversationId}/messages/draft";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutConversationsEmailMessagesDraft: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutConversationsEmailMessagesDraft: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarHeaders,
                (EmailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessage)));
            
        }

    }
}
