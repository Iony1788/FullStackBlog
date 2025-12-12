import React, { useEffect, useState } from "react";
import BlogPostService from "../servicess/BlogPostService";
import Swal from 'sweetalert2';
import { useNavigate } from "react-router-dom";
import 'bootstrap-icons/font/bootstrap-icons.css';


function ListBlogPost() {
  const [blogposts, setBlogPosts] = useState([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);
  const navigate = useNavigate();

  useEffect(() => {
    BlogPostService.getAllBlogPosts()
      .then((response) => {
        setBlogPosts(response.data);
        setLoading(false);
      })
      .catch(() => {
        setError("Error fetching blog posts");
        setLoading(false);
      });
  }, []);

  const handleDelete = (id) => {
    Swal.fire({
      title: 'Are you sure?',
      icon: 'warning',
      showCancelButton: true,
      confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
      if (result.isConfirmed) {
        BlogPostService.deleteBlogPost(id)
          .then(() => {
            setBlogPosts(blogposts.filter(p => p.id !== id));
            Swal.fire('Deleted!', 'The blog post has been deleted.', 'success');
          })
          .catch(() => {
            Swal.fire('Error', 'Failed to delete the blog post.', 'error');
          });
      }
    });
  };

  if (loading) return <h3 className="m-4 text-center">Loading blog posts...</h3>;
  if (error) return <p className="m-4 text-center text-danger">{error}</p>;

  return (
    <div className="container mt-4">
      <h2 className="mb-3 text-center text-md-start">View the blog posts</h2>

      <div className="d-flex justify-content-center justify-content-md-start mb-3">
        <button
          className="btn btn-success btn-sm"
          onClick={() => navigate("/AddBlogPost")}
        >
           <i className="bi bi-plus-lg me-1"></i> Add Blog Post
        </button>
      </div>

      <div className="table-responsive">
        <table className="table table-striped table-bordered">
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
                <td className="d-flex flex-column flex-md-row gap-2">
                  <button
                    className="btn btn-sm btn-warning"
                    onClick={() => navigate(`/EditBlogPost/${blogpost.id}`)}
                  >
                    <i className="bi bi-pencil-fill"></i>
                  </button>
                  <button
                    className="btn btn-sm btn-danger"
                    onClick={() => handleDelete(blogpost.id)}
                  >
                     <i className="bi bi-trash-fill"></i>
                  </button>
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    </div>
  );
}

export default ListBlogPost;
