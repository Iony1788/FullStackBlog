import React, { useEffect, useState } from "react";
import BlogPostService from "../services/BlogPostService";

function ListBlogPost() {
  const [blogposts, setPosts] = useState([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  useEffect(() => {
    BlogPostService.getAllBlogPosts()
      .then((response) => {
        setPosts(response.data);
        setLoading(false);
      })
      .catch((error) => {
        setError("Error fetching blog posts");
        setLoading(false);
      });
  }, []);

  if (loading) {
    return (
      <div className="container mt-4">
        <h2 className="mb-3">Loading blog posts...</h2>
      </div>
    );
  }

  if (error) {
    return (
      <div className="container mt-4">
        <p>{error}</p>
      </div>
    );
  }

  return (
    <div className="container mt-4">
      <h2 className="mb-3">View the blog posts</h2>
     <button className="btn btn-primary btn-sm me-2 mt-3" onClick={() => window.location.href = `/AddBlogPost`}>
        Add blog post
     </button>
      <table className="table table-striped table-bordered mt-4">
        <thead className="thead-dark">
          <tr>
            <th>Title</th>
            <th>Content</th>
            <th>Author</th>
            <th>Created</th>
            <th>Actions</th>
          </tr>
        </thead>
        <tbody>
          {blogposts.map((blogpost) => (
            <tr key={blogpost.id}>
              <td>{blogpost.title}</td>
              <td>{blogpost.content}</td>
              <td>{blogpost.author}</td>
              <td>{blogpost.createdAt}</td>
              <td className="d-flex">
              <button className="btn btn-sm btn-warning me-2" onClick={() => window.location.href = `/EditBlogPost/${blogpost.id}`}>
                Edit
              </button>
              <button className="btn btn-sm btn-danger" onClick={() => window.location.href = `/delete/${blogpost.id}`}>
                Delete
              </button>
            </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default ListBlogPost;
