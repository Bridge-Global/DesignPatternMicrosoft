Chain of responsibility

------------------------


Here we show an example of purchase approval system. 

If the purchase request amount is less than 100000,
the Director can approve the request.

If the request is greater than 10000, the director will pass on the approval request to the VicePresident for approval. 

The vice president will check the amount and if its between 10000 and 25000, he will approve it. 
If its greater, then vice presider will pass the approval request to the President. 

The president will check, if the amount is between 25000 and 100000. If so he will approve it, else he will call for a meeting.

