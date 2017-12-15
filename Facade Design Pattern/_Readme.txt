Facade Design pattern

-----------------------

This pattern hides the complexities of the larger system and provides a simpler interface to the client.

It typically involves a single wrapper class that contains a set of members required by the client.

These members access the system on behalf of the facade client and hide the implementation details.


 


Online Shopping example

----------------------

We have created a class called OnlineShoppingFacade and included all the required dependencies and 
object creation in a single method called PurchaseOnlineProducts. 

The PurchaseOnlineProducts method will create the required objects and purchase the object.
 So the clinet program does not have to worry about the inner complexity
.