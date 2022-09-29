using MQTTnet.Samples.Helpers;
using MQTTnet.Client;
using MQTTnet;



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
//var mqttClientOptions = new MqttClientOptionsBuilder().WithTcpServer("broker.hivemq.com").Build();
var mqttClientOptions = new MqttClientOptionsBuilder().WithConnectionUri("315cf2f48b994755bdeca8860316dfe6.s2.eu.hivemq.cloud").Build();
//mqttClientOptions.Build();
// This will throw an exception if the server is not available.
// The result from this message returns additional data which was sent 
// from the server. Please refer to the MQTT protocol specification for details.
var response = await mqttClient.ConnectAsync(mqttClientOptions, CancellationToken.None);

Console.WriteLine("The MQTT client is connected.");

response.DumpToConsole();
