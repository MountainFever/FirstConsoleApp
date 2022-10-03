using MQTTnet.Samples.Helpers;
using MQTTnet.Client;
using MQTTnet;

namespace MqttPublisher {

    class Program {

        static async Task Main(string[] args)
        {

            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("So, let´s try to get a MQTT client up and running");


            /*
             * This sample creates a simple MQTT client and connects to a public broker.
             *
             * Always dispose the client when it is no longer used.
             * The default version of MQTT is 3.1.1.
             */
            var mqttFactory = new MqttFactory();
            var mqttClient = mqttFactory.CreateMqttClient();

            // Use builder classes where possible in this project.
            var mqttClientOptions = new MqttClientOptionsBuilder()
                .WithTcpServer("315cf2f48b994755bdeca8860316dfe6.s2.eu.hivemq.cloud", 8883) //URL, Port
                .WithCredentials("Cobra390App", "8sF6e.26ALmX") //username, password
                .Build();

            // This will throw an exception if the server is not available.
            // The result from this message returns additional data which was sent 
            // from the server. Please refer to the MQTT protocol specification for details.
            mqttClient.ConnectAsync(mqttClientOptions);

            Console.WriteLine("The MQTT client is connected.");

            //response.DumpToConsole();
        }
    }
}