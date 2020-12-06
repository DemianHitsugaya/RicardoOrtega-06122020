using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using BertoniSolutionTest.Models;
using RestSharp;

namespace BertoniSolutionTest.Service
{
    public class TestService
    {
        private string _URL;
        private RestClient _restClient;
        public TestService()
        {
            _URL = ConfigurationManager.AppSettings["jsonURL"];
            _restClient = new RestClient(_URL);
        }


        public IEnumerable<AlbumModel> GetAlbums()
        {
            
            try
            {
                var request = new RestRequest("/albums",Method.GET);
                var response = _restClient.Execute<List<AlbumModel>>(request);

                return response.Data;

            }
            catch (Exception)
            {
                return new List<AlbumModel>();
            }
        }


        public IEnumerable<PhotoModel> GetPhotosByAlbum(int albumId)
        {
            try
            {
                var request = new RestRequest("/photos", Method.GET);
                request.AddParameter("albumId", albumId, ParameterType.QueryString);

                var response = _restClient.Execute<List<PhotoModel>>(request);

                return response.Data;

            }
            catch (Exception)
            {
                return new List<PhotoModel>();
            }

        }


        public IEnumerable<CommentModel> GetCommentsByPhoto(int photoId)
        {
            try
            {
                var request = new RestRequest("/comments", Method.GET);
                request.AddParameter("postId", photoId, ParameterType.QueryString);

                var response = _restClient.Execute<List<CommentModel>>(request);

                return response.Data;

            }
            catch (Exception)
            {
                return new List<CommentModel>();
            }

        }
    }
}