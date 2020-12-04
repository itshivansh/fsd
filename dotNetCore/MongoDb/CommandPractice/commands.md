# Some basics commands

> show dbs
admin   0.000GB
config  0.000GB
local   0.000GB
> use Practice
switched to db Practice
> show dbs
admin   0.000GB
config  0.000GB
local   0.000GB
> use Practice
switched to db Practice
> db.createCollection('Books')
{ "ok" : 1 }
> show dbs
Practice  0.000GB
admin     0.000GB
config    0.000GB
local     0.000GB
> show collections
Books
> db.Books.drop()
true
> show collections
> db.Books.insert({BookId:'Book1',BookName:'MongoDb',Author:'ABC',Price:100})
WriteResult({ "nInserted" : 1 })
> show collections
Books
> db.Books.insert([{BookId:'Book2',BookName:'sql',Author:'BCD',Price:200},{BookId:'Book3',BookName:'HTML',Author:'CDE',Price:300}])
BulkWriteResult({
        "writeErrors" : [ ],
        "writeConcernErrors" : [ ],
        "nInserted" : 2,
        "nUpserted" : 0,
        "nMatched" : 0,
        "nModified" : 0,
        "nRemoved" : 0,
        "upserted" : [ ]
})
> db.Books.find()
{ "_id" : ObjectId("5fc9c067380880def32f1f12"), "BookId" : "Book1", "BookName" : "MongoDb", "Author" : "ABC", "Price" : 100 }
{ "_id" : ObjectId("5fc9c4b3380880def32f1f13"), "BookId" : "Book2", "BookName" : "sql", "Author" : "BCD", "Price" : 200 }
{ "_id" : ObjectId("5fc9c4b3380880def32f1f14"), "BookId" : "Book3", "BookName" : "HTML", "Author" : "CDE", "Price" : 300 }
> db.Books.find().pretty()
{
        "_id" : ObjectId("5fc9c067380880def32f1f12"),
        "BookId" : "Book1",
        "BookName" : "MongoDb",
        "Author" : "ABC",
        "Price" : 100
}
{
        "_id" : ObjectId("5fc9c4b3380880def32f1f13"),
        "BookId" : "Book2",
        "BookName" : "sql",
        "Author" : "BCD",
        "Price" : 200
}
{
        "_id" : ObjectId("5fc9c4b3380880def32f1f14"),
        "BookId" : "Book3",
        "BookName" : "HTML",
        "Author" : "CDE",
        "Price" : 300
}
> db.Books.find({BookId:'Book2'})
{ "_id" : ObjectId("5fc9c4b3380880def32f1f13"), "BookId" : "Book2", "BookName" : "sql", "Author" : "BCD", "Price" : 200 }
> db.Books.find({BookId:'Book2'}).pretty()
{
        "_id" : ObjectId("5fc9c4b3380880def32f1f13"),
        "BookId" : "Book2",
        "BookName" : "sql",
        "Author" : "BCD",
        "Price" : 200
}
> db.Books.find({Price:{$gt:100,$lt:300}}).pretty()
{
        "_id" : ObjectId("5fc9c4b3380880def32f1f13"),
        "BookId" : "Book2",
        "BookName" : "sql",
        "Author" : "BCD",
        "Price" : 200
}
> db.Books.aggregate({$group:{_id:null,sum:{$sum:'$Price'}}})
{ "_id" : null, "sum" : 600 }
> db.Books.find().pretty()
{
        "_id" : ObjectId("5fc9c067380880def32f1f12"),
        "BookId" : "Book1",
        "BookName" : "MongoDb",
        "Author" : "ABC",
        "Price" : 100
}
{
        "_id" : ObjectId("5fc9c4b3380880def32f1f13"),
        "BookId" : "Book2",
        "BookName" : "sql",
        "Author" : "BCD",
        "Price" : 200
}
{
        "_id" : ObjectId("5fc9c4b3380880def32f1f14"),
        "BookId" : "Book3",
        "BookName" : "HTML",
        "Author" : "CDE",
        "Price" : 300
}
> db.Books.update({BookId:'Book2'},{$set:{Price:250}})
WriteResult({ "nMatched" : 1, "nUpserted" : 0, "nModified" : 1 })
> db.Books.find().pretty()
{
        "_id" : ObjectId("5fc9c067380880def32f1f12"),
        "BookId" : "Book1",
        "BookName" : "MongoDb",
        "Author" : "ABC",
        "Price" : 100
}
{
        "_id" : ObjectId("5fc9c4b3380880def32f1f13"),
        "BookId" : "Book2",
        "BookName" : "sql",
        "Author" : "BCD",
        "Price" : 250
}
{
        "_id" : ObjectId("5fc9c4b3380880def32f1f14"),
        "BookId" : "Book3",
        "BookName" : "HTML",
        "Author" : "CDE",
        "Price" : 300
}
> db.Books.remove({BookId:'Book2'})
WriteResult({ "nRemoved" : 1 })
> db.Books.find().pretty()
{
        "_id" : ObjectId("5fc9c067380880def32f1f12"),
        "BookId" : "Book1",
        "BookName" : "MongoDb",
        "Author" : "ABC",
        "Price" : 100
}
{
        "_id" : ObjectId("5fc9c4b3380880def32f1f14"),
        "BookId" : "Book3",
        "BookName" : "HTML",
        "Author" : "CDE",
        "Price" : 300
}
> db.dropDatabase()
{ "dropped" : "Practice", "ok" : 1 }
> db.Books.find().pretty()
>