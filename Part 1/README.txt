This is a simple client-server chat application created using C# and Visual Studio.  The WebSocketSharp C# library
was used to facilitate socket programming. The application allows the user to join
a single chat room, post messages, and see all messages posted by other users.  The user is instructed to create an alias,
which must be unique.

To run the application, first start the server by navigating to the ChatRoomServer directory.  Then, launch the ChatRoomServer
Visual Studio solution and click "Run."  Next, launch a chat client by navigation to the ChatClient directory and clicking
the ChatClient Visual Studio solution and clicking "Run."  You may launch any number of chat clients by opening up additional
instances of the ChatClient solution.

On launch of the client, the program will prompt you for an alias.  The client will first check if the user name contains
the character ':', which is not allowed (this is because ':' is utilized as character with special meaning).  If the user
enters an acceptable username, the client will transmit this name to the server, prefaced by a ':' character.  If the
server receives a message beginning with a colon, it will interpret the rest of the message as a user name.  If this is
the first time that a user connects to the server, the server will send back the message "You are the first user to join the chat",
which will be displayed by the client in the chat box.  If the server already has been connected to by other clients, the
server will check its list of names to see if the given name is already in use.  If it is, the server will send back a message
containing only the character ":", which the client will interpret as a "User name already in use" error message.  The client
will then prompt the user again for a user name, continuing this process until an acceptable alias is found.  Once the user
enters an acceptable name, the server will broadcast the message "<user name> has entered the chat" to all of its connected
clients.

After connecting, the users can enter chat messages into the message box and click send to send their messages to the
server.  The server will store the message in an internal list of messages and then broadcast the message to all connected clients.
Whenever a client connects to the server, all of the stored messages are sent directly to the new client so that they are up-to-date
on the chat history.