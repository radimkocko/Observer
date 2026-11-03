YoutubeChannel channel =
    new YoutubeChannel("Programování jednoduše");

Subscriber petr = new Subscriber("Petr");
Subscriber jana = new Subscriber("Jana");
Subscriber tomas = new Subscriber("Tomáš");

channel.Subscribe(petr);
channel.Subscribe(jana);
channel.Subscribe(tomas);

channel.UploadVideo("Návrhový vzor Observer");

