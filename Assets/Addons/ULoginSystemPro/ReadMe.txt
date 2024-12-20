Thanks for purchase ULogin Pro
Version 1.9.45


Get Started: 

- Import the ULogin Pro package in you Unity project.
- Add the ULogin Scenes in Build Settings, scenes are located in Assets -> Addons -> ULoginSystemPro -> Content -> Scenes, 
  be sure of set Login scene as the first scene in the build settings.
- Add the Set up your host check the In-Editor tutorial in (Unity Editor Toolbar) MFPS -> Addons -> ULogin -> Tutorial.
- In 'LoginDataBasePro' located in ULogin System Pro -> Content -> Resources set the scene to load after login in the field "OnLoginLoadLevel".
- Ready. (not needed for MFPS)

For Documentation go to MFPS -> Tutorials ->  ULogin Pro

Contact:

If you have any question or problem don't hesitate on contact us:

email: lovattostudio@gmail.com	
forum: http://www.lovattostudio.com/forum/index.php

Local Changes only = only modifications in the game client scripts, no required update server script nor database.
Server Changes = Require update the server scripts (php)
Full Update = Require update all, client scripts, server scripts and database structure.

Change Log:|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

1.9.45 (Local changes only)
-Fix: Added friends from the friend list appear corrupted after the next session.

1.9.4
-Fix: Error when try to add a new friend in the lobby.
-Fix: Can sign-in without verify email.

1.9.3
-Improve: Add option to add/deduct coins to users accounts from the Admin Panel.
-Improve: Shows user registered date in Admin Panel.
-Fix: Error caused by corrupted metadata information.

1.9.2
-Fix: Ban System.
-Fix: Non-defined exceptions from the server in some client requests.
-Improve: Update build-in documentation.

1.9 (Not compatible with older versions, a complete new installation is required.)
-Improve: Added support for custom authenticators.
-Improve: PHP scripts.
-Improve: Now PHP scripts return propers HTTP codes.
-Add: PerToPer encryption using RSA and AES (combined) algorithms from the phpseclib, this is a big improve in security,
   now all user will request an unique public key to the server who will store the private key pair in a per user session.
-Add: Max login attempts, once the user reaches it, he must wait some time until try again.
-Improve: Now password_hash() with BCRYPT is used to hash the passwords, an newest and secure method than the old md5.
-Improve: Added UI Navigation with axis.
-Improve: Added support for controller navigation.
-Improve: Now is possible reset player stats (kills, deaths, score, etc...) from the admin panel.
-Fix: Error caused by multi-line messages in support tickets.
-Fix: Moderators could ban Admins. (rule does not apply on Editor)
-Fix: 'Play as guest' use the account player name if the player have previously login and logout in the same session.
-Fix: Can't ban ipv6 users ip's
-Improve: now all the coins updates operations are processed in the server-side.
-Improve: Optimized database table structures.
-Improve: Check INTERNET connection.

1.8
-Add: Remember Me behave option, now you can select to remember just the user name or the session in LoginDataBasePro -> RememberMeBehave,
      if RememberSession is selected, player will automatically sign-in (without write user-name and password) next time that enter in game.
-Improve: Loading window, now show more details of the current query executing.
-Improve: Now submit buttons respond to the 'Enter/Return' key without the needed of manually focused the button.

1.7.5
Fix: Coins purchases where not begin saved.
Improve: MFPS Lobby player profile window popup, now you can click over the player name in order to open the player profile.
Add: User meta data, with this class (bl_UserMetaData.cs) you can easily add new fields to store as plain text (in json format) in data base.
Improve: compatibility with Class Customization addon.
Improve: Integrated the ranking window in MFPS lobby menu.
Improve: Build-in documentation.

1.7 (03/03/2020)
Add: bl_ULoginWebRequest.cs which make easier handle UnityWebRequests Operations.
Improve: Added unhidden / hide button in the password input field to make the password text visible.
Fix: Empty GUI Layer components in Login and Raking scenes cause build to fail in Unity 2019++
Improve: Add new table to store coins purchases metadata.

1.6.3
Fix: Guest Button still showing after player success log in.

1.6.1 (11/7/2019)
Fix: server was not retrieving purchases.

1.6 (20/5/2019)
Add: Game Version checking, check the In-Editor tutorial for more info.
Fix: Coins was not saved successfully
Improve: Now can force login scene, so when start from main menu will redirect automatically to Login scene.
Improve: Integrated Shop System addon. (require update database structure).

1.5.3
Fix: not define index on servers using php version 7++
Fix: Change user role was not working on Admin Panel.
Fix: Integration was not marked as dirty causing scene not save changes.

1.5
Integrate: Clan System addon (require update database structure).
Add: In-Editor tutorial, Open in MFPS -> Addons -> ULogin -> Tutorial
Fix: CPU spike when Moderator or Admin Log in.
Improve: Now nick name can't be the same as the login name.
Improve: Add more security filters to login and nick name.
Improve: Now Email field not appear if Email verification is not required.
Fix: Automatically login after write the password.
Improved: Smooth fade out when load Admin Panel.

1.4.5
Update to MFPS 1.4++

1.4
Add:  Add a filter words feature for avoid certain words on nick names, users will not be able to register the account is one of these words is present in the nick name.

1.3.5
Add: Button for admin and moderator can access to admin panel after login.
Add: DataBase creator (Editor Only), make easy way more easy create the tables needed for integration.