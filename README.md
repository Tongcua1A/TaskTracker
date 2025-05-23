Task Tracker!

Remelyn Part!

For database I use xampp MySQL,
I install MySQL Data provider
*POMELO.ENTITYFRAMEWORK.MYSQL

I use this extension because, based on my research this is one of the most popular and well maintained MySQL provider for entity framework Core its a solid choice for ASP.NET core MVC

After facing of multiple error's, I discovered that these package are compatible with each other, so i intall this pagkage for good in version of .NET 8.0 

*install-Package Microsoft.EntityFrameworkCore version 8.0.1.3.

*install-Package Microsoft.EntityFrameworkDesign version 8.0.1.3

*install-Package Microsoft.EntityFrameworkTools version 8.0.1.3

*install-Package Microsoft.EntityFrameworkCoreMYSQL version 8.0.1.3

To run the Log in and Register with a database on I use the Identity,
Microsoft.ASP.net.identity.entityFramework

Kathy Part!

bale to gin edit ko ang sa .json nga file ta hw, gin specify koto atun database, kag sa taskitemcontroller gin islan ko mn to ang sa create kg edit nga condition.
kag kada start ka edit, create nga cshtml file gin butang ko to nga dw asp-validstion= ALL dw amo kara nga line.
para kung skaali ngs may bakante ukon wra na fill ipan ma pop up ang ana nga error nga "Title field is required". kay sa taskitem.cs naka butang to nga [required] bago mag title. kag ang userID gin butangan to nga neverbind ukon kung ano nga amo kara kay kung wara tana naka bind, ga butwa tana sa UI kada mag create or edit nga userId field is required maski wara mn kita to it field nga para rigyan kay dapat ga auto increment lng ang userID sa database ta mismo. muto gin butangan kato para d dn tana ma require sa ui, tas gin islan ang ui, gin panami

