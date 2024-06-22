source : https://olegchursin.medium.com/a-brief-introduction-to-domain-modeling-862a30b38353 

![[Pasted image 20240605161351.png]]
A **domain model** is essentially a structured map of knowledge that captures the essence of a problem domain. It serves as a **visual guide** that:

- Represents the **key concepts** and **vocabulary** specific to the domain.
- Identifies and illustrates the **relationships** between various entities within the domain’s scope.

Think of it as a **visual dictionary** that abstracts complex real-world objects into simpler conceptual classes. This abstraction process helps in organizing objects into a **coherent structure**, much like how words are organized in a dictionary. The domain model stands out because it:

- Creates a **network of interconnected objects**, each symbolizing an entity that can range from a large organization to a minute detail on a document.
- Integrates both **behavior** and **data**, providing a comprehensive view that encompasses the dynamic interactions and static structures within the domain.

In summary, a domain model is not just a static diagram; it’s a dynamic representation that brings together the abstract and the concrete, the static and the dynamic, to form a clear understanding of the domain’s complexities. 

_A vehicle is a mobile_ **_machine_** _that transports people or cargo. Typical vehicles include_ **_wagons_**_,_ **_bicycles_**_,_ **_motor_** _vehicles (_**_motorcycles_**_,_ **_cars_**_,_ **_trucks_**_,_ **_buses_**_),_ **_railed_** _vehicles (_**_trains_**_,_ **_trams_**_),_ **_watercraft_** _(_**_ships_**_,_ **_boats_**_),_ **_aircraft_** _and_ **_spacecraft_**_._ **_Land_** _vehicles are classified broadly by what is used to apply steering and drive forces against the ground:_ **_wheeled_**_,_ **_tracked_**_,_ **_railed_** _or_ **_skied_**_._

## Using Noun Phrase Identification to Single Out Conceptual Classes

We will be applying a useful technique — linguistic analysis: identifying the nouns and noun phrases in textual description of a domain, and considering them as candidate conceptual classes or attributes. Therefore, here’s the list of our class candidates:

**_Machine_** _,_**_wagons_**_,_ **_bicycles_**_,_ **_motor vehicles, motorcycles_**_,_ **_cars_**_,_ **_trucks_**_,_ **_buses_**_,_ **_railed_** **_vehicles, trains_**_,_ **_trams_**_,_ **_watercraft, ships_**_,_ **_boats_**_,_ **_aircraft, spacecraft_**_._ **_Land_** **_vehicles_**_,_ **_wheeled_**_,_ **_tracked_**_,_ **_railed, skied_**_._

Transforming the above list into classes with the corresponding `Class_names`, this is what our **Vehicle** domain model may look like:


![[Pasted image 20240605161414.png]] 






