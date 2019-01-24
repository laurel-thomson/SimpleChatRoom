This is an expansion of the simple-client serve chat application created in Part 1.  A ChatRoomDirectory has been added
that keeps track of all of the ChatServers, or "Chat Rooms."  When a ChatClient is launched, the user is prompted to select
from one of the available chat rooms.  The user then connects to the chosen ChatServer.
This application was created using C# and Visual Studio.  The WebSocketSharp C# library was used to facilitate socket programming. 

To run the application, first double click on the ChatRoomDirectory.exe file (the shortcut is located in this directory).

Next, launch a ChatServer by double clicking on the ChatServer.exe shortcut.  A console application will launch that will
prompt you to enter a name for the chat room and a port number.  Chat rooms and port numbers must be unique.  The application
will use the localhost IP address for all servers.  After entering the chat room name and port number, you may type "quit"
at anytime into the server console application to close the server.  You may create any number of ChatServers by clicking on the
ChatServer.exe shortcut. 

Finally, launch a client chat by double clicking on the ClientChat.exe file (the shortcut for the client is also in this directory.
You may launch any number of clients by clicking on the ClientChat.exe shortcut repeatedly.

When a client chat is launched, you will be prompted to click on a chat room to join.  If no chat servers are connected, an error message
will show and the client will close.  After choosing a chat room, you will be prompted for a user name (see documentation for Part 1
for the procedure for verifying user names).

After connecting, the users can enter chat messages into the message box and click send to send their messages to the
server.  The server will store the message in an internal list of messages and then broadcast the message to all connected clients.
Whenever a client connects to the server, all of the stored messages are sent directly to the new client so that they are up-to-date
on the chat history.

If a server is closed (by the user typing "quit" into the console), the server will be removed from the directory's listing of chat
servers and will not be listed as an option for a user to choose.  (Make sure to type quit into the server console, rather than clicking the
X).
