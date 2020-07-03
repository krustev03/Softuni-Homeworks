let Repository = require("./solution.js");
let assert = require("chai").assert;

describe("MyTests", () => {
    describe('constructor', () => 
    {
        it('creation', () => 
        {
            let props = 
            {
                name: "string",
                age: "number"
            }
            let parser = new Repository(props);
            assert.deepEqual(parser.props, {"name": "string", "age": "number"});
            assert.deepEqual(parser.data, new Map())
            assert.deepEqual(parser.nextId.toString(), 'function () {\r\n            return id++;\r\n        }');
        });
    });
    describe('count getter', () => 
    {
        it('correct', () => 
        {
            let props = 
            {
                name: "string",
                age: "number"
            }
            let parser = new Repository(props);
            assert.deepEqual(parser.count, 0);
        });
    });
    describe('add func', () => 
    {
        it('correct', () => 
        {
            let props = 
            {
                name: "string",
                age: "number"
            }
            let entity = 
            {
                name: "pep",
                age: 17
            }
            let parser = new Repository(props);
            parser.add(entity);
            assert.deepEqual(parser.add(entity), 1);
            assert.deepEqual(parser.count, 2);
            assert.deepEqual(parser.getId(1), {"name": "pep", "age": 17});
        });
        it('incorrect props', () => 
        {
            let props = 
            {
                name: "string",
                age: "number"
            }
            let entity = 
            {
                name: "pep"
            }
            let parser = new Repository(props);
            assert.throws(() => parser.add(entity), `Property age is missing from the entity!`);
        });
        it('incorrect type', () => 
        {
            let props = 
            {
                name: "string",
                age: "number"
            }
            let entity = 
            {
                name: "pep",
                age: "ko"
            }
            let parser = new Repository(props);
            assert.throws(() => parser.add(entity), `Property age is not of correct type!`);
        });
        it('incorrect type', () => 
        {
            let properties = {
                name: "string",
                age: "number",
                birthday: "object"
            };
            let entity = {
                name: 'Stamat',
                age: 29,
                birthday: 1991
            };
            let parser = new Repository(properties);
            assert.throws(() => parser.add(entity), `Property birthday is not of correct type!`);
            
        });
    });
    describe('getId func', () => 
    {
        it('correct', () => 
        {
            let props = 
            {
                name: "string",
                age: "number"
            }
            let entity = 
            {
                name: "pep",
                age: 17
            }
            let parser = new Repository(props);
            parser.add(entity);
            assert.deepEqual(parser.getId(0), {"name": "pep", "age": 17});
            assert.deepEqual(parser.count, 1);
        });
        it('incorrect', () => 
        {
            let props = 
            {
                name: "string",
                age: "number"
            }
            let entity = 
            {
                name: "pep",
                age: 17
            }
            let parser = new Repository(props);
            parser.add(entity);
            assert.throws(() => parser.getId(1), 'Entity with id: 1 does not exist!');
        });
    });
    describe('update func', () => 
    {
        it('correct', () => 
        {
            let properties = {
                name: "string",
                age: "number",
                birthday: "object"
            };
          
            let repository = new Repository(properties);
        
            let entity = {
                name: "Pesho",
                age: 22,
                birthday: new Date("2015-03")
            };
            repository.add(entity); 
            repository.add(entity); 
            assert.deepEqual(repository.getId(0), {"name":"Pesho","age":22,"birthday": new Date('2015-03-01T00:00:00.000Z')});
            assert.deepEqual(repository.getId(1), {"name":"Pesho","age":22,"birthday": new Date('2015-03-01T00:00:00.000Z')});
            
            //Update an entity
            entity = {
                name: 'Gosho',
                age: 22,
                birthday: new Date("2015-04")
            };
            repository.update(1, entity);
          
            assert.deepEqual(repository.getId(1), {"name":"Gosho","age":22,"birthday": new Date('2015-04-01T00:00:00.000Z')});
            assert.deepEqual(repository.count, 2);
            assert.deepEqual(repository.update(1, entity), undefined);
        });
        it('incorrect', () => 
        {
            let props = 
            {
                name: "string",
                age: "number"
            }
            let entity = 
            {
                name: "pep",
                age: 17
            }
            let newEntity = 
            {
                name: "ds",
                age: 11
            }
            let parser = new Repository(props);
            parser.add(entity);
            assert.throws(() => parser.update(2, newEntity), 'Entity with id: 2 does not exist!');
        });
        it('incorrect type', () => 
        {
            let props = 
            {
                name: "string",
                age: "number"
            }
            let entity = 
            {
                name: "pep",
                age: 17
            }
            let newEntity = 
            {
                name: "ds",
                age: "num"
            }
            let parser = new Repository(props);
            parser.add(entity);
            assert.throws(() => parser.update(0, newEntity), `Property age is not of correct type!`);
        });
        it('incorrect prop', () => 
        {
            let props = 
            {
                name: "string",
                age: "number"
            }
            let entity = 
            {
                name: "pep",
                age: 17
            }
            let newEntity = 
            {
                name: "ds",
                age1: 12
            }
            let parser = new Repository(props);
            parser.add(entity);
            assert.throws(() => parser.update(0, newEntity), `Property age is missing from the entity!`);
        });
    });
    describe('del func', () => 
    {
        it('correct', () => 
        {
            let props = 
            {
                name: "string",
                age: "number"
            }
            let entity = 
            {
                name: "pep",
                age: 17
            }
            let newEntity = 
            {
                name: "pepo",
                age: 17
            }
            let parser = new Repository(props);
            parser.add(entity);
            parser.add(newEntity);
            parser.del(0);
            assert.deepEqual(parser.count, 1);
            assert.deepEqual(parser.getId(1), {"name":"pepo","age":17});
            assert.throws(() => parser.getId(0), 'Entity with id: 0 does not exist!');
        });
        it('incorrect', () => 
        {
            let props = 
            {
                name: "string",
                age: "number"
            }
            let entity = 
            {
                name: "pep",
                age: 17
            }
            let parser = new Repository(props);
            parser.add(entity);
            assert.throws(() => parser.del(-1), 'Entity with id: -1 does not exist!');
        });
    });
});