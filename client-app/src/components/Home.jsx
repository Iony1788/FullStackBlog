import React from "react";
import 'bootstrap/dist/css/bootstrap.min.css';
import '../styles/Home.css';
import { Link } from "react-router-dom";


function Home() {
  return (
    <div className="container mt-4 home-page">
      <div className="row align-items-center">
        
        <div className="col-md-6">
          <h2 className="mb-3 text-3xl font-bold text-gray-900 tracking-wide drop-shadow-sm">
            Welcome to the Blog Post
          </h2>

          <Link  to="/ListBlogPost" className="btn btn-primary mt-3">
            See All Blog Posts
          </Link>
        </div>

        <div className="col-md-6">
          <img 
            src="/imageHome.jpg" 
            alt="" 
            className="img-fluid rounded shadow"
          />
        </div>

      </div>
    </div>
  );
}

export default Home;
