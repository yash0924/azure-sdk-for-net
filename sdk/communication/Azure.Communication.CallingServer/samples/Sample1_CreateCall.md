# Create Call

This sample demonstrates how to make a call to a phone number recipient.

To get started you'll need a Communication Service Resource.  See [README][README] for prerequisites and instructions.

## Creating an `ServerCallingClient`

Server Calling clients can be authenticated using the connection string acquired from an Azure Communication Resource in the Azure Portal.

```C# Snippet:Azure_Communication_ServerCalling_Tests_Samples_CreateServerCallingClient
var connectionString = "<connection_string>"; // Find your Communication Services resource in the Azure portal
CallClient client = new CallClient(connectionString);
```

## Make a call to a phone number recipient

To make a call, call the `CreateCall` or `CreateCallAsync` function from the `CallClient`. The returned value is `CreateCallResponse` objects that contains the created Call's Id if succeed, else throws a RequestFailedException.
```C# Snippet:Azure_Communication_Call_Tests_CreateCallOptions
var createCallOption = new CreateCallOptions(
       new Uri(TestEnvironment.AppCallbackUrl),
       new List<CallModality> { CallModality.Audio },
       new List<EventSubscriptionType>
       {
           EventSubscriptionType.ParticipantsUpdated,
           EventSubscriptionType.DtmfReceived
       });
```
```C# Snippet:Azure_Communication_Call_Tests_CreateCall
CreateCallResponse createCallResponse = callClient.CreateCall(
    source: new CommunicationUserIdentifier("<source-identifier>"), // Your Azure Communication Resource Guid Id used to make a Call
    targets: new List<CommunicationIdentifier>() { new PhoneNumberIdentifier("<targets-phone-number>") }, // E.164 formatted recipient phone number
    options: createCallOption // The options for creating a call.
    );
Console.WriteLine($"Call Leg id: {createCallResponse.CallLegId}");
```

To see the full example source files, see:

* [Make a call to a phone number recipient](https://github.com/Azure/azure-sdk-for-net/blob/a20e269162fa88a43e5ba0e5bb28f2e76c74a484/sdk/communication/Azure.Communication.CallingServer/tests/samples/Sample1_CallClient.cs)

[README]: https://github.com/Azure/azure-sdk-for-net/blob/a20e269162fa88a43e5ba0e5bb28f2e76c74a484/sdk/communication/Azure.Communication.CallingServer/README.md#getting-started
