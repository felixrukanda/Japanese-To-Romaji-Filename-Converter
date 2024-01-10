# Using flask to make an api 
# import necessary libraries and functions 
from flask import Flask, jsonify, request, json
from flask_restful import Resource, Api 
import pykakasi

# creating a Flask app 
app = Flask(__name__) 
# creating an API object 
api = Api(app) 
# creating a pykakasi object
kks = pykakasi.kakasi()
  
# making a class for a particular resource 
# the get, post methods correspond to get and post requests 
# they are automatically mapped by flask_restful. 
# other methods include put, delete, etc. 
class Pykakasi_api(Resource): 
  
    # corresponds to the GET request. 
    # this function is called whenever there 
    # is a GET request for this resource 
    #def get(self): 
  
        #return jsonify({'message': 'hello world'}) 
  
    # Corresponds to POST request 
    @app.route('/translate', methods=['POST'])
    def get_query(): 
        
        data = request.get_json()
        return jsonify({'translatedText': Pykakasi.translateQuery(data.get('q'))})

     
class Pykakasi():
  
    def translateQuery(query):
        result = kks.convert(query)
        
        combinedString = '';
        for item in result:
            combinedString += item['hepburn'] + ' '
            
        return combinedString.strip()
  
  
# adding the defined resources along with their corresponding urls 
api.add_resource(Pykakasi_api, '/')
  
  
# driver function 
if __name__ == '__main__': 
  
    app.run(debug = True, host = '127.0.0.2') 