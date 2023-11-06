const { EmailClient } = require("@azure/communication-email");
// This code retrieves your connection string from an environment variable.
const connectionString = "endpoint=https://csotp.india.communication.azure.com/;accesskey=L8o8TMNuHDMKcK0/Sa0ydHLjbTbuXzoRFlaPrzqOPpshZpk5OAsqjDvGQ1ZnSCWAolJM/aVPZ8sxdT0mUE/S1Q==";
const client = new EmailClient(connectionString);

async function email() {
    const emailMessage = {
        senderAddress: "DoNotReply@4abe930c-a8f6-4ed8-a6d0-ccc42fbed7c3.azurecomm.net",
        content: {
            subject: "Test Email",
            plainText: "Hello world via email.",
        },
        recipients: {
            to: [{ address: "rahulsaini3125@gmail.com" }],
        },
    };

    const poller = await emailClient.beginSend(message);
    const result = await poller.pollUntilDone();
}

email();