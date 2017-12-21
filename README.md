# Black Radley Intelligent Exhibit System

Museum exhibits speak to us from the past, telling us about our history, community and identity.

Until now they have only spoken figuratively.  Now museum exhibits can speak to us literally, in our own voice and maybe answering our questions.

Using a Raspberry Pi 3, Windows IoT Core, the Azure Face Recognition API and a webcam, we've created a device that allows museum exhibits to recognise visitors.  The device can estimate your age, gender and emotional state then tell you something appropriate about the exhibit.  Different visitors can have different experiences depending to their age and gender and how happy they are.  We are using some Open Source software that we created earlier this year which runs on the Raspberry Pi and makes use of state-of-the-art image processing algorithms in the cloud.  All this costing under £100.  

## What is this repository for?

* Version

### How do I get set up?

* Summary of set up

UWP running on a Raspberry Pi, using API fascade on Face API.

* Configuration

The API keys are stored away from the source code. 

```
\Users\USERNAME\AppData\Roaming\Microsoft\UserSecrets\e6a4d621-9576-4a11-aa11-21f768f831c4\secrets.json
```

In thit format.

```
{
  "AppSettings:FaceApiKey": "XXXXXXXX",
  "AppSettings:EmotionApiKey": "XXXXXXXX",
  "AppSettings:TableStorageConnectionString": "DefaultEndpointsProtocol=https;AccountName=XXXXXXXX;AccountKey=XXXXXXXXX;EndpointSuffix=core.windows.net"
}
```

Alternatively use the commandline interface like this

```
dotnet user-secrets list
```

* Dependencies
* Database configuration
* How to run tests
* Deployment instructions

## Contribution guidelines

* Writing tests
* Code review
* Other guidelines

## Who do I talk to?

* Repo owner or admin
* Other community or team contact
