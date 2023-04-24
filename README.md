# Caching Repository
This repository contains tests for caching operations using two different caching strategies: Inmemory caching and Distributed caching.

# Inmemory Caching
Inmemory caching is a caching strategy where data is stored in the server's memory. This is a fast and efficient way to cache data, but it has a limitation that the data is not shared across multiple servers or instances.

# Tests
The following tests have been implemented for Inmemory caching:

* Set() - This test checks if data is correctly added to the inmemory cache.
* Get() - This test checks if data is correctly retrieved from the inmemory cache.
* Remove() - This test checks if data is correctly deleted from the inmemory cache.


# Distributed Caching
Distributed caching is a caching strategy where data is stored in a distributed system. This allows the data to be shared across multiple servers or instances, making it more scalable.

# Tests
The following tests have been implemented for Distributed caching:

* Set() / SetAsync() - This test checks if data is correctly added to the distributed cache.
* Get() / GetAsync() - This test checks if data is correctly retrieved from the distributed cache.
* RemoveAsync() - This test checks if data is correctly deleted from the distributed cache.
* SetStringAsync() - This test checks if string data is correctly added to the distributed cache.
* GetStringAsync() - This test checks if string data is correctly retrieved from the distributed cache.


# Sliding Expiration
Sliding expiration is a caching strategy where the expiration time of an item is extended each time it is accessed. This is useful when you want to keep an item in cache as long as it is frequently accessed.

# Absolute Expiration
Absolute expiration is a caching strategy where the expiration time of an item is fixed. This means that the item will be removed from cache when the expiration time is reached, regardless of whether it has been accessed or not.

# Conclusion
This repository contains tests for both Inmemory and Distributed caching strategies, as well as tests for sliding and absolute expiration. These tests ensure that the caching operations are working correctly and efficiently. You can run these tests to verify the functionality of your caching system.

# How to Use
To use this repository, simply clone it to your local machine and run the tests using your preferred testing framework. Make sure to have the appropriate dependencies installed before running the tests.
